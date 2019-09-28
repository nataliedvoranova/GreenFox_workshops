using System;

namespace BlogPost
{

   /* Create a BlogPost class that has
    an authorName
    a title
    a text
    a publicationDate
      Create a few blog post objects:
    "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
    Lorem ipsum dolor sit amet.
    
        "Wait but why" titled by Tim Urban posted at "2010.10.10."
    A popular long-form, stick-figure-illustrated blog about almost everything.
    
        "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
    Daniel Hanley, a cybersecurity engineer at IBM, 
    doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, 
    he told me that he wasn’t really into the whole organizer profile thing.*/
    class Program
    {
        static void Main(string[] args)
        {
            Class_blogpost postOne = new Class_blogpost ();
            postOne.AuthorName = "John Doe";
            postOne.Title = "Lorem Ipsum";
            postOne.Text = "Lorem ipsum dolor sit amet.";
            postOne.PublicationDate = "2000.05.04.";

            Class_blogpost postTwo = new Class_blogpost ();
            postTwo.AuthorName = "Tim Urban";
            postTwo.Title = "Wait but why";
            postTwo.Text = " A popular long-form, stick-figure-illustrated blog about almost everything.";
            postTwo.PublicationDate = "2010.10.10.";

            Class_blogpost postThree = new Class_blogpost ();
            postThree.AuthorName = "William Turton";
            postThree.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            postThree.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            postThree.PublicationDate = "2017.03.28.";

            Console.WriteLine("Author: " + postOne.AuthorName + ", Title: " + postOne.Title + ", Text: " + postOne.Text + " Published: " + postOne.PublicationDate);
            Console.WriteLine("Author: " + postTwo.AuthorName + ", Title: " + postTwo.Title + ", Text: " + postTwo.Text + " Published: " + postTwo.PublicationDate);
            Console.WriteLine("Author: " + postThree.AuthorName + ", Title: " + postThree.Title + ", Text: " + postThree.Text + " Published: " + postThree.PublicationDate);
        }
    }
}
