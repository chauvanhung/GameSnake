using System;
using System.Collections.Generic;

namespace AI_Snake.Snake
{
    /// <summary>
    /// Enum biểu diễn hướng di chuyển của con rắn
    /// </summary>
    public enum Transfer
    {
        /// <summary>
        /// Di chuyển sang trái
        /// </summary>
        LEFT,

        /// <summary>
        /// Di chuyển sang phải
        /// </summary>
        RIGHT,

        /// <summary>
        /// Di chuyển lên trên
        /// </summary>
        UP,

        /// <summary>
        /// Di chuyển xuống dưới
        /// </summary>
        DOWN
    }
}