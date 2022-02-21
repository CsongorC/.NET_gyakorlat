using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace FileExplorerApp
{
    public enum ElementType { Folder, File };
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string drive in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem()
                {
                    Header = drive,
                    Tag = drive
                };

                item.Items.Add(null);
                item.Expanded += Folder_Expanded;
                folderTrVw.Items.Add(item);
            }
        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)sender;

            if (item.Items.Count != 1 || item.Items[0] != null)
                return;

            item.Items.Clear();

            string fullPath = (string)item.Tag;
            createTreeViewSubItem(item, fullPath, ElementType.Folder);
            createTreeViewSubItem(item, fullPath, ElementType.File);
        }

        private void createTreeViewSubItem(TreeViewItem item, string fullPath, ElementType type)
        {
            getElements(fullPath, type).ForEach(path =>
            {
                TreeViewItem subItem = new TreeViewItem()
                {
                    Header = getFileFolderName(path),
                    Tag = path
                };

                switch (type)
                {
                    case ElementType.Folder:
                        subItem.Items.Add(null);
                        subItem.Expanded += Folder_Expanded;
                        item.Items.Add(subItem);
                        break;
                    case ElementType.File:
                        item.Items.Add(subItem);
                        break;
                }
            });
        }

        private static List<string> getElements(string fullPath, ElementType type)
        {
            List<string> elements = new List<string>();
            string[] strArray = null;

            switch (type)
            {
                case ElementType.Folder:
                    try
                    {
                        strArray = Directory.GetDirectories(fullPath);
                    }
                    catch { }
                    break;
                case ElementType.File:
                    try
                    {
                        strArray = Directory.GetFiles(fullPath);
                    }
                    catch { }
                    break;
            }

            if (strArray != null && strArray.Length > 0)
                elements.AddRange(strArray);

            return elements;
        }

        public static string getFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            string normalizedPath = path.Replace('/', '\\');
            int lastIndex = normalizedPath.LastIndexOf('\\');
            if (lastIndex <= 0)
                return path;

            return path.Substring(lastIndex + 1);
        }
    }
}