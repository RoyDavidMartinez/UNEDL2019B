package RecorridoMatriz;

public class RecorridoMatriz {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int[][] myMatriz = { { 1, 3, 5, 7 }, { 4, 7, 9, 7 }, { 2, 6, 8, 0 }, { 2, 4, 5, 2 } };
		RecorridoN(myMatriz);
	}

	public static void RecorridoN(int [][] myMatriz) {
			for (int i = 0;i<myMatriz.length;i++) {
				for(int j=0;j<myMatriz[i].length;j++) {
					if((i%2)==0) {
						System.out.println(" "+myMatriz[j][1]);
					}else {
						System.out.println(""+myMatriz[myMatriz.length-j-1][i]);
					
				}
			}
		}
	}
}
 