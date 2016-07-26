using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace Albert.Flex
{
	/// <summary>
	/// Special class for quickly designing an xml document 
	/// </summary>
	public abstract class XmlDoc: Notify
	{
	
		private XElement doc, second;


		public XmlDoc()
		{

		}

		public XmlDoc(string firstElement, string secondElement)
		{
			//Setup xml document 
			doc = new XElement(firstElement);
			second = new XElement(secondElement);
			doc.Add(second);

		
		

			/*Document will look like this 
			 * <firstElement>
			 * <secondElement>
			 * ...
			 * </secondElement>
			 * </firstElement>
			 
			 */
		}

		/// <summary>
		/// Event happens when you save a document 
		/// </summary>
		public event Action OnSaved;
		/// <summary>
		/// Event happes when you load a document 
		/// </summary>
		public event Action OnLoaded;

		/// <summary>
		/// Gets or sets the MainDocument 
		/// </summary>
		public XElement XmlFile
		{
			get { return doc; }
			set { doc = value; }
		}
		
		/// <summary>
		/// Get or sets the second element of the xml tree
		/// </summary>
		public XElement XmlDocument
		{
			get
			{
				return second;
			}
			set
			{
				second = value;
			}
		}


		/// <summary>
		/// Returns a basic query of the xml document
		/// </summary>
		/// <param name="doc">get's the xml document</param>
		/// <param name="querystring">gets the name of the element that will be used</param>
		/// <returns></returns>
		public virtual IEnumerable<XElement> QueryDocument(XElement doc, string querystring)
		{
			var rquery = from document in doc.Descendants(querystring)
						 select document;

			return rquery;
		}



		public void Load()
		{
			if (OnLoaded != null)
			{
				//Execute OnLoaded 
				OnLoaded();

			}
		}

		public void Save()
		{
			if (OnSaved != null)
			{

				//Execute OnSaved 
				OnSaved();

			}
		}

		public void SaveAndLoad()
		{
			//Execute 
			OnSaved();
			OnLoaded();
		}



	}
}
