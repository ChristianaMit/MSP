using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public interface IExecuter{
        void Execute(string command, FileSystemReader file);
    }
}