using Lucene.Net.Documents;
using Lucene.Net.Search;
using MineracaoProj1Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineracaoProj1Gui
{
    public partial class TelaPrincipal : Form
    {
        private MineracaoProj1Business.Searcher _searcher;

        public TelaPrincipal()
        {
            InitializeComponent();
            this.dropdownlist.SelectedIndex = 0;
            _IndexAll();
            _SearchAll();
        }

        private void _SearchAll(bool normal = false)
        {
            string dropdown = string.Empty;

            if (normal)
                dropdown = EProcessType.Normal.GetDescription();
            else
                dropdown = this.dropdownlist.Text;

            this._searcher = new MineracaoProj1Business.Searcher(dropdown);
        }

        private void _IndexAll(bool normal = false)
        {
            string dropdown = string.Empty;

            if (normal)
                dropdown = EProcessType.Normal.GetDescription();
            else
                dropdown = this.dropdownlist.Text;

            Indexer indexer = new Indexer(dropdown);
            string dataDirectory = Constants.BASEPATH;
            indexer.IndexFiles(dataDirectory);
            indexer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ClearListView();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
        }

        private void bn_search_Click(object sender, EventArgs e)
        {
            _ClearListView();

            if (this.searchQuery.Text.ElementAt(0) == '"' && this.searchQuery.Text.ElementAt(this.searchQuery.Text.Length - 1) == '"')
            {
                _IndexAll(true);
                _SearchAll(true);
            }
            if (!string.IsNullOrEmpty(this.searchQuery.Text) && !string.IsNullOrWhiteSpace(this.searchQuery.Text))
                _Search(this.searchQuery.Text);
        }

        private void _Search(string query)
        {
            TopDocs hits = this._searcher.Search(query);

            foreach (ScoreDoc scoreDoc in hits.ScoreDocs)
            {
                Document doc = this._searcher.GetDocument(scoreDoc);
                this.listViewResult.Items.Add(doc.Get(Constants.FILE_NAME));
            }

            this._searcher.Close();
        }

        private void _ClearListView()
        {
            this.listViewResult.Clear();
            this.listViewResult.Columns.Add("Resultados", 775);
        }

        private void dropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IndexAll();
            _SearchAll();
        }
    }
}
