using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    // move the player icon
    public new static void UpdatePosition(string input, out int xMove, out int yMove)
    {
      if (input == "DownArrow" || input == "S")
      {
        xMove = 0;
        yMove = 1;
      }
      else if (input == "LeftArrow" || input == "A")
      {
        xMove = -1;
        yMove = 0;
      }
      else if (input == "RightArrow" || input == "D")
      {
        xMove = 1;
        yMove = 0;
      }
      else if (input == "UpArrow" || input == "W")
      {
        xMove = 0;
        yMove = -1;
      }
      else
      {
        xMove = 0;
        yMove = 0;
      }
    }

    // update the character used for the player icon
    public new static char UpdateCursor(string input)
    {
      if (input == "DownArrow" || input == "S")
      {
        return 'v';
      }
      else if (input == "RightArrow" || input == "D")
      {
        return '>';
      }
      else if (input == "LeftArrow" || input == "A")
      {
        return '<';
      }
      else if (input == "UpArrow" || input == "W")
      {
        return '^';
      }
      else
      {
        return '?';
      }
    }

    // this will make sure player can't go out of bounds
    // called twice--once for x coordinate, once for y
    // max = maximum coordinate in game, exclusive (hence the -1)
    public new static int KeepInBounds(int coordinate, int max)
    {
      if (coordinate < 0)
      {
        return max-1;
      }
      else if (coordinate > max)
      {
        return 0;
      }
      else
      {
        return coordinate;
      }
    }

    // allows score to increase if player gets the fruit
    public new static bool DidScore(int playerX, int playerY, int fruitX, int fruitY)
    {
      if (playerX == fruitX && playerY == fruitY)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}