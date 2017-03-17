using System;
using System.Collections.Generic;

namespace TerminalSimulator{

    public class Directory: Entity{

        public List<Entity> Children { get; set; }
        public string Name { get; set; }
        public Entity Parent { get; set; }

        public void AddChild( Entity child ){
            Children.Add(child);
        }

        public void RemoveChid(Entity child){
            Children.Remove(child);
        }


    }
}