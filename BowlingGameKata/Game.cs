﻿namespace BowlingGameKata
{
    public class Game
    {
        private int score = 0;

        public void Roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score;
        }
    }
}
