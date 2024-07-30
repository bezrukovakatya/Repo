using System;

namespace PROJECT{

    struct book
    {
        private string title, author, intro;
        private short pages;

        public void setValues(string title, string author) {
            this.title = title;
            this.author = author;
        }

        public void printValues() {
            Console.WriteLine(this.author + " написала книгу: \"" + this.title + "\"");
        }
    }

}