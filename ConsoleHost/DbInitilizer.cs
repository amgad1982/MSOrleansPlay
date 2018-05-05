using System;
using System.Collections.Generic;
using System.Text;
using Data.Contexts;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleHost
{
    public static class DbInitilizer
    {
        public static void Initialize(AppSqlContext context)
        {
            context.Database.Migrate();

            context.Set<Board>().Add(new Board
            {
                BoardHeader = "Board 1",
                BoarCollections = new List<Collection>
                {
                    new Collection()
                    {
                        CollectionHead = "Collection 1",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    },
                    new Collection()
                    {
                        CollectionHead = "Collection 2",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    },new Collection()
                    {
                        CollectionHead = "Collection 3",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    },new Collection()
                    {
                        CollectionHead = "Collection 4",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    }
                }
            });

            context.Set<Board>().Add(new Board
            {
                BoardHeader = "Board 2",
                BoarCollections = new List<Collection>
                {
                    new Collection()
                    {
                        CollectionHead = "Collection 1",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    },
                    new Collection()
                    {
                        CollectionHead = "Collection 2",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    },new Collection()
                    {
                        CollectionHead = "Collection 3",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    },new Collection()
                    {
                        CollectionHead = "Collection 4",
                        CollectionItems = new List<CollectionItem>
                        {
                            new CollectionItem{ItemHeader = "Item 1",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 2",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 3",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 4",ItemContent = "Content"},
                            new CollectionItem{ItemHeader = "Item 5",ItemContent = "Content"}
                        }
                    }
                }
            });
            context.SaveChanges();
        }
    }
}
