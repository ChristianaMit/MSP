using System;
using System.Collections.Generic;

namespace TerminalSimulator{

    public class Directory: Entity{
        public List<Entity> children = new List<Entity>(); 
        public Directory parent;
        public void AddChild( Entity child ){
            children.Add(child);
        }

        public void RemoveChid(Entity child){
            children.Remove(child);
        }


    }
}