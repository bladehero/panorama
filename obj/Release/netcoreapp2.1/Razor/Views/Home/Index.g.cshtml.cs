#pragma checksum "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f390fc6279ecce082ea490c93be15b2ca6f2c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
using OdekuTour.Settings.Hotspots;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f390fc6279ecce082ea490c93be15b2ca6f2c6f", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
   
    var scenes = OdekuTour.Loader.Scenes;
    var main = OdekuTour.Loader.Main;
    var units = OdekuTour.Loader.Units;

#line default
#line hidden
            BeginContext(167, 29, true);
            WriteLiteral("\r\n<div id=\"panorama\"></div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(213, 179, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            var viewer = pannellum.viewer(\'panorama\', {\r\n                \'default\': {\r\n                    \'firstScene\': \'");
                EndContext();
                BeginContext(393, 18, false);
#line 14 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                              Write(main.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(411, 53, true);
                WriteLiteral("\',\r\n                },\r\n                \'scenes\': {\r\n");
                EndContext();
#line 17 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                     foreach (var scene in scenes)
                    {

#line default
#line hidden
                BeginContext(539, 23, true);
                WriteLiteral("                       ");
                EndContext();
                BeginContext(564, 2, true);
                WriteLiteral(" \'");
                EndContext();
                BeginContext(567, 24, false);
#line 19 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                      Write(scene.Name.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(591, 29, true);
                WriteLiteral("\': {\r\n                       ");
                EndContext();
                BeginContext(622, 16, true);
                WriteLiteral("   \'panorama\': \'");
                EndContext();
                BeginContext(639, 14, false);
#line 20 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                    Write(scene.Panorama);

#line default
#line hidden
                EndContext();
                BeginContext(653, 27, true);
                WriteLiteral("\',\r\n                       ");
                EndContext();
                BeginContext(682, 25, true);
                WriteLiteral("   \'showFullscreenCtrl\': ");
                EndContext();
                BeginContext(708, 45, false);
#line 21 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                             Write(scene.ShowFullscreenCtrl.ToString().ToLower());

#line default
#line hidden
                EndContext();
                BeginContext(753, 26, true);
                WriteLiteral(",\r\n                       ");
                EndContext();
                BeginContext(781, 15, true);
                WriteLiteral("   \'autoLoad\': ");
                EndContext();
                BeginContext(797, 35, false);
#line 22 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                   Write(scene.AutoLoad.ToString().ToLower());

#line default
#line hidden
                EndContext();
                BeginContext(832, 26, true);
                WriteLiteral(",\r\n                       ");
                EndContext();
                BeginContext(860, 11, true);
                WriteLiteral("   \'hfov\': ");
                EndContext();
                BeginContext(872, 39, false);
#line 23 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                               Write(scene.Hfov.ToString().Replace(",", "."));

#line default
#line hidden
                EndContext();
                BeginContext(911, 26, true);
                WriteLiteral(",\r\n                       ");
                EndContext();
                BeginContext(939, 17, true);
                WriteLiteral("   \'hotSpots\':[\r\n");
                EndContext();
#line 25 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                            foreach (var hotspot in scene.Hotspots)
                            {

#line default
#line hidden
                BeginContext(1056, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1090, 35, true);
                WriteLiteral("{\r\n                                ");
                EndContext();
                BeginContext(1127, 10, true);
                WriteLiteral(" \'pitch\': ");
                EndContext();
                BeginContext(1138, 42, false);
#line 28 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                       Write(hotspot.Pitch.ToString().Replace(",", "."));

#line default
#line hidden
                EndContext();
                BeginContext(1180, 35, true);
                WriteLiteral(",\r\n                                ");
                EndContext();
                BeginContext(1217, 8, true);
                WriteLiteral(" \'yaw\': ");
                EndContext();
                BeginContext(1226, 40, false);
#line 29 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                     Write(hotspot.Yaw.ToString().Replace(",", "."));

#line default
#line hidden
                EndContext();
                BeginContext(1266, 35, true);
                WriteLiteral(",\r\n                                ");
                EndContext();
                BeginContext(1303, 10, true);
                WriteLiteral(" \'type\': \'");
                EndContext();
                BeginContext(1314, 12, false);
#line 30 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                       Write(hotspot.Type);

#line default
#line hidden
                EndContext();
                BeginContext(1326, 36, true);
                WriteLiteral("\',\r\n                                ");
                EndContext();
                BeginContext(1364, 64, true);
                WriteLiteral(" \'createTooltipFunc\': hotspot,\r\n                                ");
                EndContext();
                BeginContext(1430, 57, true);
                WriteLiteral(" \'createTooltipArgs\': {\r\n                                ");
                EndContext();
                BeginContext(1489, 16, true);
                WriteLiteral("      \'title\': \'");
                EndContext();
                BeginContext(1506, 13, false);
#line 33 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                             Write(hotspot.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1519, 36, true);
                WriteLiteral("\',\r\n                                ");
                EndContext();
                BeginContext(1557, 19, true);
                WriteLiteral("      \'subtitle\': \'");
                EndContext();
                BeginContext(1577, 16, false);
#line 34 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                                Write(hotspot.Subtitle);

#line default
#line hidden
                EndContext();
                BeginContext(1593, 36, true);
                WriteLiteral("\',\r\n                                ");
                EndContext();
                BeginContext(1631, 22, true);
                WriteLiteral("      \'description\': \'");
                EndContext();
                BeginContext(1654, 19, false);
#line 35 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                                   Write(hotspot.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1673, 36, true);
                WriteLiteral("\',\r\n                                ");
                EndContext();
                BeginContext(1711, 17, true);
                WriteLiteral("      \'footer\': \'");
                EndContext();
                BeginContext(1729, 14, false);
#line 36 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                              Write(hotspot.Footer);

#line default
#line hidden
                EndContext();
                BeginContext(1743, 36, true);
                WriteLiteral("\',\r\n                                ");
                EndContext();
                BeginContext(1781, 5, true);
                WriteLiteral(" },\r\n");
                EndContext();
#line 38 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                if(hotspot is InfoHotspot infoHotspot)
                                {

#line default
#line hidden
                BeginContext(1893, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1927, 9, true);
                WriteLiteral(" \'URL\': \'");
                EndContext();
                BeginContext(1937, 15, false);
#line 40 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                      Write(infoHotspot.URL);

#line default
#line hidden
                EndContext();
                BeginContext(1952, 4, true);
                WriteLiteral("\',\r\n");
                EndContext();
#line 41 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                }
                                else if (hotspot is SceneHotspot sceneHotspot)
                                {

#line default
#line hidden
                BeginContext(2106, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2140, 75, true);
                WriteLiteral(" \'clickHandlerFunc\': hotspotClickHandler,\r\n                                ");
                EndContext();
                BeginContext(2217, 30, true);
                WriteLiteral(" \'clickHandlerArgs\': { \'id\': \'");
                EndContext();
                BeginContext(2248, 34, false);
#line 45 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                                           Write(sceneHotspot.SceneId.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(2282, 38, true);
                WriteLiteral("\' },\r\n                                ");
                EndContext();
                BeginContext(2322, 13, true);
                WriteLiteral(" \'sceneId\': \'");
                EndContext();
                BeginContext(2336, 34, false);
#line 46 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                          Write(sceneHotspot.SceneId.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(2370, 3, true);
                WriteLiteral("\'\r\n");
                EndContext();
#line 47 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2408, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2442, 4, true);
                WriteLiteral("},\r\n");
                EndContext();
#line 49 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(2477, 23, true);
                WriteLiteral("                       ");
                EndContext();
                BeginContext(2502, 6, true);
                WriteLiteral(" ]},\r\n");
                EndContext();
#line 51 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2531, 1693, true);
                WriteLiteral(@"                }
            });

            viewer.on('mousedown', function (event) {
                console.log(viewer.getPitch(), viewer.getYaw());
                console.log(viewer.mouseEventToCoords(event));
            });
            
            function hotspot(hotSpotDiv, args) {
                $(hotSpotDiv).mouseenter(function (e) {
                    $('#description.card>.card-body>.card-title').text("""").append(args.title);
                    $('#description.card>.card-body>.card-subtitle').text("""").append(args.subtitle);
                    $('#description.card>.card-body>.card-text').text("""").append(args.description);
                    $('#description.card>.card-footer>.card-text').append("""");
                    $('#description.card>.card-footer').remove();
                    if (args.footer && args.footer.trim() != '') {
                        var footer = '<div class=\""card-footer\""><p class=\""card-text text-right text-warning\"">'
                            + args");
                WriteLiteral(@".footer + '</p></div>';
                        $('#description.card').append(footer);
                    }
                    $('#description').removeClass('fadeIn animated fadeOut invisible').addClass('animated fadeIn');
                });
                $(hotSpotDiv).mouseout(function () {
                    $('#description').addClass('animated fadeOut');
                });
            }
            function hotspotClickHandler(obj, args) {
                $('#description').addClass('animated fadeOut');
                $('.nav-link').removeClass('active');
                $('#' + args.id).addClass('active');
            }
            $('#");
                EndContext();
                BeginContext(4225, 18, false);
#line 83 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
           Write(main.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(4243, 77, true);
                WriteLiteral("\').addClass(\'active\').click(function () {\r\n                viewer.loadScene(\'");
                EndContext();
                BeginContext(4321, 18, false);
#line 84 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                             Write(main.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(4339, 122, true);
                WriteLiteral("\');\r\n                $(\'.nav-link\').removeClass(\'active\');\r\n                $(this).addClass(\'active\');\r\n            });\r\n");
                EndContext();
#line 88 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
             foreach (var unit in units)
            {

#line default
#line hidden
                BeginContext(4518, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(4536, 5, true);
                WriteLiteral(" $(\'#");
                EndContext();
                BeginContext(4542, 23, false);
#line 90 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                  Write(unit.Name.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(4565, 39, true);
                WriteLiteral("\').click(function() {\r\n                ");
                EndContext();
                BeginContext(4606, 23, true);
                WriteLiteral("     viewer.loadScene(\'");
                EndContext();
                BeginContext(4630, 23, false);
#line 91 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
                                    Write(unit.Name.GetHashCode());

#line default
#line hidden
                EndContext();
                BeginContext(4653, 21, true);
                WriteLiteral("\');\r\n                ");
                EndContext();
                BeginContext(4676, 60, true);
                WriteLiteral("     $(\'.nav-link\').removeClass(\'active\');\r\n                ");
                EndContext();
                BeginContext(4738, 50, true);
                WriteLiteral("     $(this).addClass(\'active\');\r\n                ");
                EndContext();
                BeginContext(4790, 6, true);
                WriteLiteral(" });\r\n");
                EndContext();
#line 95 "C:\Users\Asus\Desktop\OdekuTour\OdekuTour\OdekuTour\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(4811, 28, true);
                WriteLiteral("        });\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
