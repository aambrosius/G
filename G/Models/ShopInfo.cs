namespace G.Models
{
    public class ShopInfo
    {
        //public string Image { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
        //public string Price { get; set; }
        //public int Quantity { get; set; }
        public ShopInfo(string image, string title, string description, string price, int quantity)
        {
            Image = image;
            Title = title;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
        #region Variables

        private string _image;
        private string _title;
        private string _description;
        private string _price;
        private int _quantity;

        #endregion

        #region Getters/Settters

        public string Image { get { return _image; } set { _image = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Price { get { return _price; } set { _price = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        #endregion
    }
}