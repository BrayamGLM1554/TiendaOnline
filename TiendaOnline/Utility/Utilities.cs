namespace TiendaOnline.Utility
{
    public class Utilities
    {
        public static string AuthAPIBase { get; set; }
        public static string ShoppingCartAPIBase { get; set; }
        public static string CouponAPIBase { get; set; }
        public static string OrderAPIBase { get; set; }
        public static string ProductAPIBase { get; set; }
        public const string TookenCookie = "JWTToken";
        public const string RoleAdmin = "ADMINISTRADOR";
        public const string RoleCostumer = "CUSTOMER";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        /// <summary> Esta propiedad nos sirve para poder 
        public enum ContentType
        {
            Json,
            MultipartFormData
        }

        public const string Status_Pending = "Pendiente";
        public const string Status_Approved = "Aprovado";
        public const string Status_ReadyForPickup = "Listo para recoger";
        public const string Status_Completed = "Completo";
        public const string Status_Refunded = "Regresado";
        public const string Status_Cancelled = "Cancelado";
    }
}
