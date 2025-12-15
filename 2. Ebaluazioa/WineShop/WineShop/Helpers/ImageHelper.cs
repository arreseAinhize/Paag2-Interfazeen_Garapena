// Crear esta carpeta y archivo si no existe:
// WineShop/Helpers/ImageHelper.cs

using System;

namespace WineShop.Helpers
{
    public static class ImageHelper
    {
        public static string GetWineImageByMotaId(int? motaId)
        {
            if (!motaId.HasValue)
                return "~/images/wine-default.jpg";

            return motaId.Value switch
            {
                1 => "~/images/wine-red.jpg",     // Tinto
                2 => "~/images/wine-white.jpg",   // Blanco  
                3 => "~/images/wine-rose.jpg",    // Rosado
                4 => "~/images/wine-sparkling.jpg", // Espumoso
                _ => "~/images/wine-default.jpg"  // Por defecto
            };
        }
    }
}