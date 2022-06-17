using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace mimari_proje
{
    public partial class FormXML : Form
    {
        public FormXML()
        {
            InitializeComponent();
        }

        private void FormXML_Load(object sender, EventArgs e)
        {

            
                // 1. Read XML File from a local path
                string xmlString = File.ReadAllText("XMLrapor.xml", Encoding.UTF8);

                // 2. Create a XML DOM Document and load the data into it.
                XmlDocument dom = new XmlDocument();
                dom.LoadXml(xmlString);

                // 3. Initialize the TreeView control. treeView1 can be created dinamically
                // and attached to the form or you can just drag and drop the widget from the toolbox
                // into the Form.

                // Clear any previous content of the widget
                treeView1.Nodes.Clear();
                // Create the root tree node, on any XML file the container (first root)
                // will be the DocumentElement name as any content must be wrapped in some node first.
                treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));

                // 4. Create an instance of the first node in the treeview (the one that contains the DocumentElement name)
                TreeNode tNode = new TreeNode();
                tNode = treeView1.Nodes[0];

                // 5. Populate the TreeView with the DOM nodes with the helper 'AddNode' function
                this.AddNode(dom.DocumentElement, tNode);
           
        }
        /// <summary>
        /// Renders a node of XML into a TreeNode. Recursive if inside the node there are more child nodes.
        /// </summary>
        /// <param name="inXmlNode"></param>
        /// <param name="inTreeNode"></param>
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            // If the node has child nodes, the function will call itself.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;

                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRaporMenu formRaporMenu = new FormRaporMenu();
            this.Hide();
            formRaporMenu.Show();
        }
    }
}
