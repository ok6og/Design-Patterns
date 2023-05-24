using System;
using System.Collections.Generic;
using System.Text;

namespace designPattterns.command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
