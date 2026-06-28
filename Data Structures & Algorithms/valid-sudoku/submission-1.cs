public class Solution {
    public bool IsValidSudoku(char[][] board) {

        //Check Unique elements in the Row using Dictionary of Int and HashSet
        //Check Unique elements in the column using Dictionary of Int and HashSet
        //Check Unique element in the 3X3 box . Find the position of the element in the box 
        //using (Row/3 , Column/3)
        Dictionary<int,HashSet<char>> Row = new Dictionary <int,HashSet<char>>();
        Dictionary<int,HashSet<char>> Column = new Dictionary<int,HashSet<char>>();
        Dictionary<(int,int),HashSet<char>> Box= new Dictionary<(int,int),HashSet<char>>(); 

        for(int i =0; i < board.Length; i++)//For Rows 
        {
            for(int j=0; j<board[0].Length; j++)//For Column
            {
                if(board[i][j]!='.')
                {
                    if(!Column.ContainsKey(j))
                {
                    Column.Add(j,new HashSet<char>());
                }
                if(!Row.ContainsKey(i))
                {
                    Row.Add(i,new HashSet<char>());
                }
                var boxKey = (i/3,j/3);

                if(!Box.ContainsKey(boxKey))
                {
                    Box.Add(boxKey,new HashSet<char>());
                }
                
                if(Column[j].Contains(board[i][j]) || Row[i].Contains(board[i][j]) 
                || Box[boxKey].Contains(board[i][j]))
                {
                    return false;
                }
                else
                {
                    Column[j].Add(board[i][j]);
                    Row[i].Add(board[i][j]);
                    Box[boxKey].Add(board[i][j]);
                }

                }
                    
            }
        }
        return true;        
    }
}
