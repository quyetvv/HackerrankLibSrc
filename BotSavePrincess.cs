using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static void displayPathtoPrincess(int n, String [] grid){
    int mx = -1, my = -1, px = -1, py = -1;
    getPosition("m",grid,out mx, out my);
    getPosition("p",grid,out px, out py);
    int horStep = mx - px;
    int verStep = my - py;
    for (int i = 0; i < Math.Abs(horStep); i++){
        if (horStep < 0){
            Console.WriteLine("RIGHT");
        }
        else {
            Console.WriteLine("LEFT");            
        }
    }
    
    for (int i = 0; i < Math.Abs(verStep); i++){
        if (verStep < 0){
            Console.WriteLine("DOWN");            
        }
        else {
            Console.WriteLine("UP");
        }
    }
}
    
static void getPosition(string input,String [] grid,out int x,out int y){
    x = -1;
    y = -1;
    for (int i = 0 ; i < grid.Length; i++){
        if (grid[i].IndexOf(input) >= 0 ){
            y = i;
            x = grid[i].IndexOf(input);
            return;
        }
    }
}
static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}
