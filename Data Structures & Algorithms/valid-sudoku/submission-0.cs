public class Solution {
    public bool IsValidSudoku(char[][] board) {

        //Check Unique elements in the Row using Dictionary 
        //Check Unique elements in the column using Dictionary
        //Check Unique element in the 3X3 box . Find the position of the element in the box 
        //using (Row/3 , Column/3)
        Dictionary<int,Dictionary<int,int>> Row = new Dictionary <int,Dictionary<int,int>>();
        Dictionary<int,Dictionary<int,int>> Column = new Dictionary<int,Dictionary<int,int>>();
        Dictionary<(int,int),Dictionary<int,int>> Box= new Dictionary<(int,int),Dictionary<int,int>>(); 

        for(int i =0; i < board.Length; i++)//For Rows 
        {
            for(int j=0; j<board[0].Length; j++)//For Column
            {
                if(board[i][j]!='.')
                {
                    if(!Column.ContainsKey(j))
                {
                    Column.Add(j,new Dictionary<int,int>());
                }
                if(!Row.ContainsKey(i))
                {
                    Row.Add(i,new Dictionary<int,int>());
                }
                var boxKey = (i/3,j/3);

                if(!Box.ContainsKey(boxKey))
                {
                    Box.Add(boxKey,new Dictionary<int,int>());
                }
                
                if(Column[j].ContainsKey(board[i][j]) || Row[i].ContainsKey(board[i][j]) 
                || Box[boxKey].ContainsKey(board[i][j]))
                {
                    return false;
                }
                else
                {
                    Column[j].Add(board[i][j],1);
                    Row[i].Add(board[i][j],1);
                    Box[boxKey].Add(board[i][j],1);
                }

                }
                
                
            }
        }
        return true;        
    }
}
