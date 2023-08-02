using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace PKM.XRM.SecurityManager.XRMTool
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Security Manager"),
        ExportMetadata("Description", "Complete Security Manager for Dynamics CRM / Dataverse / Power Platform"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAAsTAAALEwEAmpwYAAACMklEQVR4nL2Xz0tVQRTHPz0h8SUYiWALIUGKQMiFCzWhQl2Fi1pFYGtFF4UL/QeEVuJK2ogpiNEv/EWgpBEtWjxQoTZWElRuJCQsLcxfDJ1sus7cmfvu9X3hC497z/d8D/Nmzj0D2aEeeAB8Eo4CF8kBGoA5YM/COYlJFMeAZuB1iHGQ88AtIBXH+DRwG3gbwTjIN5Kj1McwBVQD3cAssB3DOEiV6znQJR6HVqYIWEvQ0MU18TzAiRya/2X6n/2fJdmNmGAFeCh8F1G7I5v7P2x4CH8K1e8+TdtleB/GdQz47BBtAk1AJZABrmnaK8ACcEFiNh25lk0FvHSIdEMXbjpyzZhEgw7R/QgFPHXk6jeJuh0itUlLDM0q2GQqPPZAh6mAS5bgX0AtcDIQ3yYNRrE18O4UUCdaU84qUwFpYMsQrE6HCR+0mPeWGNPJ+gbkWeJ5FaGACS1mPEIBjwnBHcuSrcqnVm+fxUCPUC25vpKTwBdLrhthBZSFdMRF4DhuqLa+ZMmhVqTQlWDGIr6MP2osOe75iK9axBk5CaqHtwBnNU2JNCr1Lh+Yshzj8z4FpEKGkIzMCnvy3+tHUj2bBp5ZtKGbL4hmj2byAmgUjjlifwPniIhZjyJ82UsWKAe+J2D+0Wfn29Ae03wrifvCSIwCOkkABbLhoprrE1NspD0GFp1DcS8lJhR53o6Gw752cZEPDFiMVae7a5p2jwJtwA/N/CtwPRfGOs4AT4BHMpplhX2/GezPYTp3EgAAAABJRU5ErkJggg=="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAYAAACOEfKtAAAACXBIWXMAAAsTAAALEwEAmpwYAAAFb0lEQVR4nO2dbYgVVRjHf9uu5ermJlhZWVZkRWUQlmAWGUR9qiBWyYjKyJU+VEZl0gttEaRsSmWUFlGU0Zt9SIsyDJKEFCVbqw0qSFcqQotNTbfadeLAszCMc2fOzHm55967P3i+7Nw95z//nXtenzMLYdEETAeeBNYAmyXWyM8ukc+MkGA8sBjoA6Kc6JPPqt9peI4Hngb2axiXDPU73cCERnTxOOAJYF8J45KxT8pSZdY9bcCDwJ8WjEszcgnQTh0yFlgE7HFgXDJUHQ9InTXPCUAXsNeDccnoB54FTqEGmSLiD1bBuGT8A7wOXEDgHAPMAT4FDgdgXDKUpvXAbNEaBEcBM4EVwB8BmKQbqkl5TrR7H5i3ALOA5cDuAMwwjT65lyvk3pxwBnA78J40zlGdRj/wLjAPON3ka3k+MB94Q3N6FdVp9IkH88UT5U0u0wIQHgUayptcLgpAaBRoKG9ymRqA0CjQUF/jXM4JQGgUaKgJQi5nBiA0CjQm6xg4KQChUaBxko6B46os8kvp7dJiSZW1teoYqKY2/1VR5LIMbddUUZdaGNHG9brdUMa1WzJ0TS5Zpo34pYiBPzgUMgjMBToqrBNemKFLzQT+Tpl+3ShlDjrU/U0RAzc5NO/mWD0nAh/Frg8Ao3K0fRX7/FbgrNi12Q6bn0+KGPiWwycvrc1dCGwD7iCfa4GNwNIKZt/k6El8mQJ0O37yXDPHwZP4aBEB91iufAH+6bJ8D7cVqfw6y5W/j1/UjtxPlu/h0iICpliuPAI68ccKB/oLpZI0S49oU8AhWelxzUwHY8JfywjZ4eCvuA23tDr46qrYUEbMagdCPsYtzY4MVHPwwiy0VHm/5Pi9UqAhvhr4DDggWVjqCbiqQAe4WgbZNpKXVNxQti0xqXRpybSK+ypszKuf3VuivEmixeReVBmFGWM4GO0sUee0nA5gSHdfIkGn4c5caTZ7NnCVRrkvejbwNQx4yrOBmzTK/cKzgVnLa1qNuU8D19teFbFgYKn2L94OHvJo4CKNcu/3aOB2LPChRwPHATszyvwZONajgWpBwpgFJSsfAHqAd4DHZIlJLaDmcS7wfUp5vbJnnYfK/btYTFMdzhaDRM8yPf4RnGxxbrlSs85Rsrq8TKJDY6V6mOWWtP6IRT63JKoX92Q1Ad6/vjZ6sSg2k1Dbkq6525KBOs2FNuMtLG+txA9qj2WtoVY1HrXO2waCdpbsPU3+4LsM9Kr21zqzDAR14J8rS2rd5TJX+luDzmMi/miSLPwyWtUpJ2fcafAU9mScrBwNXKabgywHC1syzCu7J3LA9TFatWT+u2UTpwPfyfXdMn3MoksGxltTTh+ZmKfiBTzwiIHAKGbiaFkqHyw4+o+fGlAjg4fkaTQ1799Emogz2i1kb+2QdjHtWlr6xzATMjarXjXU9DwesbVfEhWcAbjKD9yvOU+3xtGOdr8iGW9WYrGjOgvlvdhirqOb+U2W9tOi11F96iS9d5qk7YlqPHymnBzB5R5Sa13GxgJjz5pK5Ik8xEHdgzOuGeOwQ3EZZfZWnE7cDwdgim5skTyaoFgVgDG6893zCJCxBqs1PuNWAubswF8J4GtV3IjrA20Pe3TPuoVAdwCGxWOPHOOtGVqAdQEYNzzem0EN0iqZVNU0b6hsdmkotEvbUy0D76IOONVitkCReJg64jTJNfFlXlXW91wzUc7cjphn+ELG7Q47DLXVUPe0AR9YNm9ATq03DM3AM5bM2ysLuw3JvJR3IBSJr+XVfA3N1AopvXnxpkYWQ8PQJi+t1dlf6Tc9u1HPzIjlyaTFBhmYj5CTZf94IrP+L5mWjfwnB/RRJ4TUMYWXPOcWFuJ/ZPEMTwaY0hoAAAAASUVORK5CYII="),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}