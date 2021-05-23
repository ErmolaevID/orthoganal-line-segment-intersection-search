using System;

namespace orthoganal_line_segment_intersection_search
{
    public class BinaryTree : IBinarySearchTree<int>
    {
        public IBinarySearchTreeNode<int> Root { get; set; }
     
        public bool Add(int value)
        {
            IBinarySearchTreeNode<int> before = null, after = this.Root;
     
            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                      after = after.LeftNode; 
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            var newNode = new Node { Data = value };

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
     
            return true;
        }
     
        public IBinarySearchTreeNode<int> Find(int value)
        {
            return this.Find(value, this.Root);            
        }
     
        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }
     
        private IBinarySearchTreeNode<int> Remove(IBinarySearchTreeNode<int> parent, int key)
        {
            if (parent == null) return parent;
     
            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key); else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);
     
            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;
     
                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);
     
                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
     
            return parent;
        }
     
        private int MinValue(IBinarySearchTreeNode<int> node)
        {
            int minv = node.Data;
     
            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
     
            return minv;
        }
     
        private IBinarySearchTreeNode<int> Find(int value, IBinarySearchTreeNode<int> parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
     
            return null;
        }
    }
}