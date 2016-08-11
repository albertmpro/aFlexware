using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Collections.ObjectModel;

namespace Albert.Flex.Windows
{
	/// <summary>
	/// A special list design for working with ViewModel's of the MVVM pattern 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class DesktopVMList<T> : ObservableCollection<T>
	{
		#region Field's 

		//Field's 
		XElement root, document;
		bool isAnInsert = false;
		#endregion

		#region Constructor's 
		/// <summary>
		/// Default Constructor 
		/// </summary>
		public DesktopVMList()
		{
			// Do nothing 

		}
		/// <summary>
		/// Xml Constructor 
		/// </summary>
		/// <param name="_rootName"></param>
		/// <param name="_documentName"></param>
		public DesktopVMList(string _rootName, string _documentName)
		{

			//Declare the root of the xml document  
			root = new XElement(_rootName);
			//Declare the document of element 
			document = new XElement(_documentName);
			//Add document to the root 
			root.Add(document);
			/* resault 
			 *	<file>
			 *		<document>
			 *			Content is entered here ...
			 *		</document>
			 *	</file>
			 */
		}

		public DesktopVMList(string _rootName, string _documentName, Action _savemethod, Action _loadmethod)
		{
			//Declare the root of the xml document  
			root = new XElement(_rootName);
			//Declare the document of element 
			document = new XElement(_documentName);
			//Add document to the root 
			root.Add(document);

			//Link to SaveCommand 
			SaveCommand = new VMCommand(_savemethod);
			//Link to LoadCommand 
			LoadCommand = new VMCommand(_loadmethod);

		}

		public DesktopVMList(Action _savemethod,Action _loadmethod)
		{
			//Link to SaveCommand 
			SaveCommand = new VMCommand(_savemethod);
			//Link to LoadCommand 
			LoadCommand = new VMCommand(_loadmethod);
		}

		#endregion


		#region Commands

		public VMCommand LoadCommand { get; set; }
		public VMCommand SaveCommand { get; set; }

		#endregion




		#region Public Method's 



		public void ForEach(Action<T> _method)
		{
			foreach (var i in this)
			{
				_method?.Invoke(i);
			}
		}

		///<summary>
		/// Query's an xml document
		/// </summary>
		/// <param name="doc">get's the xml document</param>
		/// <param name="querystring">gets the name of the decendants name that will be used</param>
		/// <returns></returns>
		public IEnumerable<XElement> QueryDocument(XElement doc, string querystring)
		{
			//Create a query that will grab the elements that you want 
			var rquery = from document in doc.Descendants(querystring)
						 select document;

			return rquery;
		}

		public void AddToXmlDocument(XElement item)
		{
			if (document != null)
				document.Add(item);
		}


		#endregion

		#region Public Properties
		/// <summary>
		/// Gets or sets the entire Xml File 
		/// </summary>
		public XElement XmlFile
		{
			get
			{
				return root;
			}
			set
			{
				root = value;
			}
		}
		/// <summary>
		/// Gets or sets the Xml document
		/// </summary>
		public XElement XmlDocument
		{
			get
			{
				return document;
			}
			set
			{
				document = value;
			}
		}
		public bool IsAnInsert
		{
			get
			{
				return isAnInsert;
			}
			set
			{
				isAnInsert = value;
			}
		}



		#endregion
	}
}
