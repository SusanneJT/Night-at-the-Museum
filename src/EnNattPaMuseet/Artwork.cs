using System;

namespace EnNattPaMuseet
{
    public class Artwork
    {
        
        private string title;
        private string description;
        private string creator;

        public Artwork(string title, string description, string creator) {
            this.title = title;
            this.description = description;
            this.creator = creator;
        }


        public override string ToString() => string.Format($"En tavla målad av {creator}, {description}");

        public string GetArtworkTitle() {
            return title;
        }
    }
}
