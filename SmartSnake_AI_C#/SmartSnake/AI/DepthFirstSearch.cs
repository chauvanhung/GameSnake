using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AI_Snake.Snake;

namespace AI_Snake.AI
{
    static class DepthFirstSearch
    {
        static Stack<State> Open;

        public static State DFS(State start, State goal, Screen screen)
        {
            try
            {
                State temp;
                State[] continueState = new State[4];
                int number = 0;
                Open = new Stack<State>();
                ScreenType x;

                //Close = new Queue<State>();

                screen.ClearVisited();

                Open.Push(start);
                screen.ChangeTypeAt(start.Coordinates, ScreenType.VISITED);
                while (Open.Count != 0)
                {
                    temp = Open.Pop();
                    if (temp.Equal(goal))
                        return temp;

                    #region Open := Open + succs(n)

                    number = temp.Succs(ref continueState);
                    for (int i = 0; i < number; i++)
                    {
                        x = screen.GetScreenTypeAt(continueState[i].Coordinates);
                        if (x == ScreenType.BLANK
                           || x == ScreenType.FOOD)
                        {
                            Open.Push(continueState[i]);
                            screen.ChangeTypeAt(continueState[i].Coordinates, ScreenType.VISITED);
                        }
                    }
                    #endregion

                    //Close.Enqueue(temp);
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
