using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web.Http;

namespace FoodSelfhost
{
    public class ProductController : ApiController
    {
        internal Program Program
        {
            get => default(Program);
            set{}
        }

        public string GetTotalPrice()
        {
            DataTable lcResult = clsDbconnection.GetDataTable("SELECT sum(price*quantity) as totalprice FROM orderinfo", null);
            return lcResult.Rows[0]["totalprice"].ToString();
        }
        
        public List<clsOrder> GetOrder()
        {
            DataTable lcResult = clsDbconnection.GetDataTable("SELECT * FROM orderinfo", null);
            List<clsOrder> lcOrder = new List<clsOrder>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrder.Add(dataRow2Order(dr));
            return lcOrder;
        }

        public List<string> GetPlaceNames()
        {
            DataTable lcResult = clsDbconnection.GetDataTable("SELECT place_name FROM place", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public clsPlace GetPlace(string PlaceName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("place_name", PlaceName);
            DataTable lcResult =
            clsDbconnection.GetDataTable("SELECT * FROM place WHERE place_name = @place_name", par);
            if (lcResult.Rows.Count > 0)
                return new clsPlace()
                {
                    PlaceName = (string)lcResult.Rows[0]["place_name"],
                    Code = lcResult.Rows[0]["code"].ToString(),
                    ProductsList = getProducts(PlaceName)
                };
             else
                return null;
        }

        public clsPlace GetPlaceInstock(string PlaceName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("place_name", PlaceName);
            DataTable lcResult =
            clsDbconnection.GetDataTable("SELECT * FROM place WHERE place_name = @place_name", par);
            if (lcResult.Rows.Count > 0)
                return new clsPlace()
                {
                    PlaceName = (string)lcResult.Rows[0]["place_name"],
                    Code = lcResult.Rows[0]["code"].ToString(),
                    ProductsList = getProductsInstock(PlaceName)
                };
            else
                return null;
        }

        private List<clsAllProduct> getProducts(string PlaceName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("place_name", PlaceName);

            DataTable lcResult = clsDbconnection.GetDataTable("SELECT * FROM product WHERE place_name = @place_name", par);
            List<clsAllProduct> lcProducts = new List<clsAllProduct>();
            foreach (DataRow dr in lcResult.Rows)
                lcProducts.Add(dataRow2AllProduct(dr));
            return lcProducts;
        }

        private List<clsAllProduct> getProductsInstock(string PlaceName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("place_name", PlaceName);

            DataTable lcResult = clsDbconnection.GetDataTable("SELECT * FROM product WHERE place_name = @place_name AND instock > 0", par);
            List<clsAllProduct> lcProducts = new List<clsAllProduct>();
            foreach (DataRow dr in lcResult.Rows)
                lcProducts.Add(dataRow2AllProduct(dr));
            return lcProducts;
        }

        public void reduceStock(clsOrder prOrder)
        {   // update     
            //try
            //{
                
                int lcRecCount = clsDbconnection.Execute("UPDATE product SET instock = instock - @Quantity WHERE product_name = @ProductName AND  place_name = @PlaceName",

                    prepareOrderParameters(prOrder));
            /*    //if (lcRecCount == 1)
                   // return "One product updated";
                //else
                   // return "Unexpected product update count: "   + lcRecCount;
            }
            catch (Exception ex)
            {
                //return ex.GetBaseException().Message;
            }*/
        }

        private clsAllProduct dataRow2AllProduct(DataRow prDataRow)
        {
            return new clsAllProduct()
            {
                ProductName = Convert.ToString(prDataRow["product_name"]),
                Date = Convert.ToDateTime(prDataRow["date"]),
                Price = Convert.ToDecimal(prDataRow["price"]),
                Instock = Convert.ToInt16(prDataRow["instock"]),
                Category = Convert.ToString(prDataRow["category_id"]),
                ProductId = Convert.ToInt16(prDataRow["product_id"]),
                Quality = Convert.ToString(prDataRow["quality"]),
                Freshness = Convert.ToString(prDataRow["freshness"]),
                Amount = Convert.ToString(prDataRow["amount"]),

                PlaceName = Convert.ToString(prDataRow["place_name"]),
            };
        }

        private clsOrder dataRow2Order(DataRow prDataRow)
        {
            return new clsOrder()
            {
                OrderId = Convert.ToInt16(prDataRow["order_id"]),
                ProductName = Convert.ToString(prDataRow["product_name"]),
                Date = Convert.ToDateTime(prDataRow["date"]),
                Price = Convert.ToDecimal(prDataRow["price"]),
                PlaceName = Convert.ToString(prDataRow["place_name"]),
                Contact = Convert.ToString(prDataRow["contact"]),
                Quantity = Convert.ToInt16(prDataRow["quantity"]),
            };
        }

        public string PutPlace(clsPlace prPlace)
        { // update
            try
            {
                int lcRecCount = clsDbconnection.Execute(
                "UPDATE Place SET code = @Code WHERE place_name = @PlaceName",
                preparePlaceParameters(prPlace));
                if (lcRecCount == 1)
                    return "One place updated";
                else
                    return "Unexpected place update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }
        
        public string PostOrder(clsOrder prOrder)
        { // insert
            try
            {
                int lcRecCount = clsDbconnection.Execute(
                "INSERT INTO orderinfo ( product_name, place_name, price, quantity, contact ) VALUES ( @ProductName, @PlaceName, @Price, @Quantity,@Contact )",
                prepareOrderParameters(prOrder));
                if (lcRecCount == 1)
                {
                    reduceStock(prOrder);
                    return "Order Placed";
                }
                else
                    return "Order Faild";
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PostPlace(clsPlace prPlace)
        { // insert
            try
            {
                int lcRecCount = clsDbconnection.Execute(
                "INSERT INTO place ( place_name ,code ) VALUES ( @PlaceName, @Code )",
                preparePlaceParameters(prPlace));
                if (lcRecCount == 1)
                    return "One place inserted";
                else
                    return "Unexpected place insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteOrder(string OrderID)
        {
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>(1);
                par.Add("order_id", OrderID);
                int lcRecCount = clsDbconnection.Execute("DELETE FROM orderinfo WHERE order_id = @order_id",
                   par);
                if (lcRecCount == 1)
                    return "One order deleted";
                else
                    return "Unexpected order deleted count: "
                        + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeletePlace(string PlaceName)
        {
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>(1);
                par.Add("place_name", PlaceName);
                int lcRecCount = clsDbconnection.Execute("DELETE FROM place WHERE place_name = @place_name",
                   par);
                if (lcRecCount == 1)
                    return "One place deleted";
                else
                    return "Unexpected place deleted count: "
                        + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteProduct(string ProductName, string PlaceName)
        {
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>(2);
                par.Add("product_name", ProductName);
                par.Add("place_name", PlaceName);
                int lcRecCount = clsDbconnection.Execute("DELETE FROM product WHERE product_name = @product_name AND  place_name = @place_name",
                   par);
                if (lcRecCount == 1)
                    return "One product deleted";
                else
                    return "Unexpected product deleted count: "
                        + lcRecCount + ProductName + PlaceName;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutProduct(clsAllProduct prProduct)
        {   // update     
            try
            {
                int lcRecCount = clsDbconnection.Execute("UPDATE product SET quality = @Quality, amount = @Amount, freshness = @Freshness, price = @Price, instock = @Instock WHERE product_name = @ProductName AND place_name = @PlaceName",
                   
                    prepareProductParameters(prProduct,null));
                if (lcRecCount == 1)
                    return "One product updated";
                else
                    return "Unexpected product update count: "
                        + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PostProduct(clsAllProduct prProduct)
        {   // insert     
            try     {
                int lcRecCount = clsDbconnection.Execute("INSERT INTO product " +    
                    "(product_name, price, instock, category_id, place_name, quality, amount, freshness) " + 
                    "VALUES (@ProductName, @Price, @Instock, @Category, @PlaceName, @Quality, @Amount, @Freshness)",    
                    prepareProductParameters(prProduct,null));
                if (lcRecCount == 1)
                    return "One product inserted";
                else
                    return "Unexpected product insert count: " 
                        + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareProductParameters(clsAllProduct prProduct, string prQuantity)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("ProductId", prProduct.ProductId);
            par.Add("ProductName", prProduct.ProductName);
            par.Add("Price", prProduct.Price);
            par.Add("Instock", prProduct.Instock);
            par.Add("Category", prProduct.Category);
            par.Add("PlaceName", prProduct.PlaceName);

            par.Add("Freshness", prProduct.Freshness);
            par.Add("Quality", prProduct.Quality);
            par.Add("Amount", prProduct.Amount);

            par.Add("Date", prProduct.Date);
            
            return par;
        }
        
        private Dictionary<string, object> preparePlaceParameters(clsPlace prPlace)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(3);
            par.Add("PlaceName", prPlace.PlaceName);
            par.Add("Code", prPlace.Code);
            return par;
        }

        private Dictionary<string, object> prepareOrderParameters(clsOrder prOrder)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("OrderID", prOrder.OrderId);
            par.Add("ProductName", prOrder.ProductName);
            par.Add("Price", prOrder.Price);
            par.Add("PlaceName", prOrder.PlaceName);
            par.Add("Quantity", prOrder.Quantity);
            par.Add("Contact", prOrder.Contact);
            par.Add("Date", prOrder.Date);
            return par;
        }
    }
}
