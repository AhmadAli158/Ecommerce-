using System.ComponentModel.DataAnnotations;

namespace Ecommerce_app.Data
{
	public class product
	{
        [Key]
        public int Product_id { get; set; }
        public int Product_name { get; set; }
        public int Product_url { get; set; }
        public int Product_detail { get; set; }
    }
}
