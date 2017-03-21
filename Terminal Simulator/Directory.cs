using System;
using System.Collections.Generic;

namespace TerminalSimulator{

    public class Directory: Entity{
        public List<Entity> children = new List<Entity>(); 
        public void AddChild( Entity child ){
            children.Add(child);
        }

        public void RemoveChid(Entity child){
            children.Remove(child);
        }
    }
}