using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        SortedDictionary<string, Books> bookinfo = new SortedDictionary<string, Books>();

        static string[] headings = new string[6]; //for headings in file

        //the following object contains(will contain) the currently selected book
        Books selectedBook = new Books();

        public Form1()
        {
            InitializeComponent();
            var path = @"../../datafiles/Books.csv"; //change file name accordingly

            //reading data from the file.

            string[] lines = System.IO.File.ReadAllLines(path);



            foreach (string line in lines)
            {

                //for the first headings line in file

                if (line.StartsWith("Book-Name"))

                    headings = line.Split(',');

                // Adding data into the dictionary. The first “info[0]” is book-name-will be added as key and others as value (by creating a new object of Books class) Question : what is happening below ? can you think of simple way ?   
                else
                {
                    string[] info = line.Split(',');

                    bookinfo.Add(info[0], new Books
                    {

                        Price = Convert.ToDouble(info[1]),
                        Isbn = info[2],
                        Author = info[3],
                        PublishedYear = Int32.Parse(info[4]),
                        SimiBooks = info[5]
                    });
                }
            }

            refreshForm(); // method for loading data into listboxs.

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void refreshForm()
        { 
            displayBooksinbooklistbox();

        }

        private void displayBooksinbooklistbox()
        {
            //bind booklistbox to bookinfo Dictionary collection.

            booklistbox.DataSource = new BindingSource(bookinfo, null);

            //display the entries by key. Read about Listbox control here      

            booklistbox.ValueMember = "Key";

            label3.Text = booklistbox.Items.Count.ToString();
            label4.Text = similarbookslistbox.Items.Count.ToString();

        }

        private void booklistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookinfo.ContainsKey(booklistbox.SelectedValue.ToString()))

                //update selected Book
                selectedBook = bookinfo[booklistbox.SelectedValue.ToString()];

            //update similarbookslistbox
            similarbookslistbox.DataSource = selectedBook.SimilarBooks;

            // Just for count of no. of entries in both listboxes
            label4.Text = similarbookslistbox.Items.Count.ToString();
            resultlbl.Text = booklistbox.Items.Count.ToString();


            // Question: from where and how are these (below) data coming?

            priceBox.Text = selectedBook.Price.ToString();
            isbnBox.Text = selectedBook.Isbn;
            authorBox.Text = selectedBook.Author;
            yearBox.Text = selectedBook.PublishedYear.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBookbtn_Click(object sender, EventArgs e)
        {
            addnewBook ab = new addnewBook();

            //execute addBookFormClosed() on form closed. The below is a delegate ab.FormClosed where we are adding a FormClosedevent handler which will trigger the method addBookFormClosed. It is basically saying if the Form ‘ab’ is closed then execute addbookFormClosed method (which we will code in step k below).

            ab.FormClosed += new FormClosedEventHandler(addBookFormClosed);

            ab.Show();

        }


        void addBookFormClosed(object sender, FormClosedEventArgs e)
        {


            if (Program.newBookName != null)
                bookinfo.Add(Program.newBookName, new Books
                {
                    Price = 0,
                    Isbn = null,
                    Author = null,
                    PublishedYear = 0,
                    SimiBooks = "[none]"
                });

            Program.newBookName = null;
            displayBooksinbooklistbox();


        }

        private void addSimilarBookbtn_Click(object sender, EventArgs e)
        {
            addSimilarBookForm asimi = new addSimilarBookForm();
            asimi.FormClosed += new FormClosedEventHandler(addsimilarFormClosed);
            asimi.Show();

        }

        void addsimilarFormClosed(object sender, EventArgs e)
        {

            //add Similar books to selectedBook on booklistbox

            selectedBook.SimilarBooks.Add(Program.newSimlilarBookName);


            Program.newSimlilarBookName = null;

            //save selectedbook inside bookinfo dictionary
            if (bookinfo.ContainsKey(booklistbox.SelectedValue.ToString()))
                bookinfo[booklistbox.SelectedValue.ToString()] = selectedBook;

            //refresh similarbookslistbox

            similarbookslistbox.DataSource = null;
            similarbookslistbox.DataSource = selectedBook.SimilarBooks;

            //refresh similarbooks count label
            label4.Text = similarbookslistbox.Items.Count.ToString();

        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            selectedBook.Price = Double.Parse(priceBox.Text);
            selectedBook.Isbn = isbnBox.Text;
            selectedBook.Author = authorBox.Text;
            selectedBook.PublishedYear = Int32.Parse(yearBox.Text);

        }

        private void searchBox_Text(object sender, EventArgs e)
        {
            if (searchBox.Text != "") //check if searchBox is empty
            {
                //check if there is only one letter entered in searchBox

                if (searchBox.Text.Length == 1)
                {
                    //capitalise the letter- no need if you have entered small letter for   first letter of Book-Name

                    searchBox.Text = searchBox.Text.ToString().ToUpper();
                    searchBox.Select(searchBox.Text.Length, 0);
                }

                //create dictionary "filtered" which stores all Books that contain letters that are entered in searchBox

                var filtered = bookinfo.Where(d => d.Key.Contains(searchBox.Text)).ToDictionary(d => d.Key, d => d.Value);

                //check if filtered dictionary contains entries

                if (filtered.Count > 0)
                {
                    //show results in booklistbox

                    booklistbox.DataSource = new BindingSource(filtered, null);
                    booklistbox.ValueMember = "Key";
                    noresultlbl.Visible = false; //hide noResultsLbl

                    //show resultsLbl which contains the number of mathes

                    resultlbl.Visible = true;

                    //if filtered contains only one match output "match"

                    if (filtered.Count == 1) resultlbl.Text = filtered.Count + " match";

                    //if filtered contains more than one match output "matches"

                    else resultlbl.Text = filtered.Count + " matches";

                }
                else
                {
                    noresultlbl.Visible = true; //show noResultsLbl
                    resultlbl.Visible = false; //hide resultsLbl
                }
            }
            else
            {
                displayBooksinbooklistbox();
                resultlbl.Visible = noresultlbl.Visible = false;
            }
            label3.Text = booklistbox.Items.Count.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
