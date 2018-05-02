using JProject.ServicesTest.Entities;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JProject.ServicesTest.Helper
{
    public class SPHelper
    {
        /// <summary>
        /// check list exists
        /// </summary>
        /// <param name="siteUrl"></param>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <param name="domain"></param>
        /// <param name="listName"></param>
        /// <returns></returns>
        public bool IsListExists(string siteUrl, string userName, string pwd, string domain, string listName)
        {
            ClientContext clientContext = new ClientContext(siteUrl);
            clientContext.Credentials = new NetworkCredential(userName, pwd, domain);

            ListCollection listCollection = clientContext.Web.Lists;
            clientContext.Load(listCollection, lists => lists.Include(list => list.Title).Where(list => list.Title == listName));
            clientContext.ExecuteQuery();

            if (listCollection.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// check list exists
        /// </summary>
        /// <param name="clientContext"></param>
        /// <param name="listName"></param>
        /// <returns></returns>
        public bool IsListExists(ClientContext clientContext, string listName)
        {
            //ClientContext clientContext = new ClientContext(siteUrl);
            //clientContext.Credentials = new NetworkCredential(userName, pwd, domain);

            ListCollection listCollection = clientContext.Web.Lists;
            clientContext.Load(listCollection, lists => lists.Include(list => list.Title).Where(list => list.Title == listName));
            clientContext.ExecuteQuery();

            if (listCollection.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<TicketEntity> GetTicketItems(string siteUrl, string userName, string pwd, string domain, string listName)
        {
            try
            {
                List<TicketEntity> ticketEntitiesList = new List<TicketEntity>();
                ClientContext clientContext = new ClientContext(siteUrl);
                clientContext.Credentials = new NetworkCredential(userName, pwd, domain);

                bool flag = IsListExists(clientContext, listName);
                if (flag)
                {
                    ListCollection lists = clientContext.Web.Lists;
                    IEnumerable<List> results = clientContext.LoadQuery<List>(lists.Where(lst => lst.Title == listName));
                    clientContext.ExecuteQuery();
                    List list = results.FirstOrDefault();

                    if (list != null)
                    {
                        //load all items into List<ListItem>
                        CamlQuery camlQuery = new CamlQuery();
                        camlQuery.ViewXml = "<View Scope='RecursiveAll'><RowLimit>5000</RowLimit></View>";

                        List<ListItem> items = new List<ListItem>();
                        do
                        {
                            ListItemCollection listAllItems = list.GetItems(camlQuery);
                            clientContext.Load(listAllItems);
                            clientContext.ExecuteQuery();

                            //Adding the current set of ListItems in our single buffer
                            items.AddRange(listAllItems);
                            //Reset the current pagination info
                            camlQuery.ListItemCollectionPosition = listAllItems.ListItemCollectionPosition;

                        } while (camlQuery.ListItemCollectionPosition != null);

                        foreach (ListItem item in items)
                        {
                            ListItem currentItem = list.GetItemById(item.Id);
                            clientContext.Load(currentItem);
                            clientContext.ExecuteQuery();


                            if (currentItem != null)
                            {
                                TicketEntity ticketEntity = new TicketEntity();
                                ticketEntity.title = item["Title"] == null ? "" : item["Title"].ToString();
                                ticketEntity.budget = item["Budgeting"] == null ? false : Convert.ToBoolean(item["Budgeting"]);
                                ticketEntity.urgency = item["Urgency"] == null ? "" : item["Urgency"].ToString();
                                ticketEntity.deadline = item["Deadline"] == null ? DateTime.MinValue : Convert.ToDateTime(item["Deadline"]);
                                ticketEntity.subject = item["Subject"] == null ? "" : item["Subject"].ToString();
                                ticketEntity.content = item["Content"] == null ? "" : item["Content"].ToString();
                                ticketEntity.category = item["Category"] == null ? "" : item["Category"].ToString();
                                ticketEntity.assignTo = item["AssignmentTo"] == null ? "" : item["AssignmentTo"].ToString();
                                ticketEntity.department = item["Department"] == null ? "" : item["Department"].ToString();
                                ticketEntity.response = item["Response"] == null ? "" : item["Response"].ToString();
                                ticketEntitiesList.Add(ticketEntity);
                            }

                        }

                    }


                }
                return ticketEntitiesList;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
