using System;
using System.Collections.Generic;
using System.IO;
class Solution {
  static void nextMove(int player, String [] board){
    for (int i = 0 ; i < board.Length - 1; i ++){
        int colIndex = 0;
        colIndex = board[i].IndexOf("11",colIndex);
        while (colIndex >= 0){
            if (board[i + 1][colIndex] == '1'){
                board[i] = board[i].Remove(i,2);
                board[i] = board[i].Insert(i,"00");
                board[i + 1] = board[i+1].Remove(i,1);
                board[i+1] = board[i+1].Insert(i,"0");
                
                Console.WriteLine(i + " " + colIndex);
            };
            colIndex = board[i].IndexOf("11",colIndex);
        }
    }
  }
  static void Main(String[] args) {
        int player;

        //If player is 1, I'm the first player.
        //If player is 2, I'm the second player.
        player = int.Parse(Console.ReadLine());

        //Read the board now. The board is a 8x8 array filled with 1 or 0.
        String[] board  = new String[8];
        for(int i=0; i < 8; i++) {
            board[i] = Console.ReadLine(); 
        }
        
        nextMove(player,board);
        
     }
}
