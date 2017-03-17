using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public interface IExecuter{
        void Execute(string command);
        void Execute(string command, Directory dir);
        void Execute();
    }
}