namespace GameLab
{   /// <summary>
    ///абстракція для ігрових об'єктів
    /// </summary>
    interface IObject
    {
        /// <summary>
        /// у кожного об'єкта на ігровому полі повинна бути дія, активована під час "зустрічі" з ним
        /// </summary>
        void Action(Player player);
    }
}
