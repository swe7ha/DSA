//Space Complexity O(n) for rows and columns array and constant space for diagonal

//Time Complexity O(1)

public class TicTacToe {
    int[] rows;
    int[] cols;
    int diagonal = 0;
    int antidiagonal =0;
    int boardSize = 0;
    public TicTacToe(int n) {
        rows = new int[n];
        cols = new int[n];
        boardSize = n;
    }
    
    public int Move(int row, int col, int player) {
       rows[row] += player == 1 ? 1 : -1;
       cols[col] += player == 1 ? 1 : -1;
       if(row == col){
           diagonal += player == 1 ? 1 : -1;;
       }
       if(col == boardSize-row-1){
           antidiagonal += player == 1 ? 1 : -1;
       }
       
       return Math.Abs(rows[row]) == boardSize || Math.Abs(cols[col]) == boardSize || Math.Abs(diagonal) == boardSize || Math.Abs(antidiagonal) == boardSize ? player : 0;
    }
   
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */

 public class Program {
    public static void Main(string[] args) {
        // Create a TicTacToe object with board size 3
        TicTacToe game = new TicTacToe(3);
        
        // Simulate some moves
        Console.WriteLine(game.Move(0, 0, 1)); // Player 1 moves to cell (0, 0)
        Console.WriteLine(game.Move(0, 2, 2)); // Player 2 moves to cell (0, 2)
        Console.WriteLine(game.Move(2, 2, 1)); // Player 1 moves to cell (2, 2)
        Console.WriteLine(game.Move(1, 1, 2)); // Player 2 moves to cell (1, 1)
        Console.WriteLine(game.Move(2, 0, 1)); // Player 1 moves to cell (2, 0)
        Console.WriteLine(game.Move(1, 0, 2)); // Player 2 moves to cell (1, 0)
        Console.WriteLine(game.Move(2, 1, 1)); // Player 1 moves to cell (2, 1)
        
        // The game is finished, no more moves can be made
    }
}