using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    /*
     * Towers of Hanoi: In the classic problem of the Towers of Hanoi, you have 3 towers and N disks of
     * different sizes which can slide onto any tower. The puzzle starts with disks sorted in ascending order
     * of size from top to bottom (Le., each disk sits on top of an even larger one). You have the following
     * constraints:
     * (1) Only one disk can be moved at a time.
     * (2) A disk is slid off the top of one tower onto another tower.
     * (3) A disk cannot be placed on top of a smaller disk.
     * Write a program to move the disks from the first tower to the last using stacks.
     */
    public class TowersOfHanoi
    {
        public static void TowersOfHanoiAlgo(Stack<int> first, Stack<int> second, Stack<int> last)
        {
            TowersOfHanoiAlgo(first.Count, first, second, last);
        }

        private static void TowersOfHanoiAlgo(int count, Stack<int> origin, Stack<int> buffer, Stack<int> dest)
        {
            if (count <= 0)
                return;
            TowersOfHanoiAlgo(count - 1, origin, dest, buffer);
            MoveTop(origin, dest);
            TowersOfHanoiAlgo(count - 1, buffer, origin, dest);
        }

        private static void MoveTop(Stack<int> origin, Stack<int> dest)
        {
            dest.Push(origin.Pop());
        }
    }
}
