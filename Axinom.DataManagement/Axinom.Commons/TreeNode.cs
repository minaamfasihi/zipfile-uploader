using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace Axinom.DataManagement {
    public class TreeNode {
        public string name { get; set; }
        public List<TreeNode> children { get; set; }

        public TreeNode(string n) {
            name = n;
            children = new List<TreeNode>();
        }
    }
}
