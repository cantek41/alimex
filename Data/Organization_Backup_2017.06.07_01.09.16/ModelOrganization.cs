using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class ModelOrganization
    {
        public Node Node { get; set; }
    }
    public class Node
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public IList<NodeMember> ss { get; set; }

        public IList<Node> Nodes { get; set; }
    }
    public class NodeMember
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
