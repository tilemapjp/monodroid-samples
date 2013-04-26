
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content.PM;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Support.V4.App;
using Android.Widget;

using Java.Net;

namespace MapsAndLocationDemo
{
    class OsmTileProvider : UrlTileProvider
    {
        private static string OsmUrlFormat =
            "http://tile.openstreetmap.org/{0}/{1}/{2}.png";

        public OsmTileProvider() : base (256, 256)
        {
        }

        public override URL GetTileUrl(int x, int y, int zoom) 
        {
            string s = String.Format(OsmUrlFormat, zoom, x, y);
            URL url = null;
            //try {
                url = new URL(s);
            //} catch ( MalformedURLException e) {
            //    throw new Java.Lang.AssertionError(e);
            //}
            return url;
        }
    }
}

