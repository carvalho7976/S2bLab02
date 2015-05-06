using Lab03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula02 {
    public partial class Default : System.Web.UI.Page { 
        
        protected void Page_Load(object sender, EventArgs e) {
            /*int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++) {
                Response.Write("Indice = " + i + " & Valor = " + array[i]
                + "<br>");
            }*/
           /* string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++) {
                Response.Write("Indice = " + iStr + " & Valor = " + str[iStr]
                + "<br>");
            }
            * */
           /* DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] =
            new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++) {
                Response.Write("Indice = " + iDate + " & Data = " +
                dt[iDate].ToShortDateString() + "<br>");
            }*/
            //execicio 01
            int[] array01 = new int[10];
            int[] array02 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array01.Length; i++) {
                array01[i] = rnd.Next(1, 100);
            }
            array02 = array01;
            for (int i = 0; i < array01.Length; i++) {
                Response.Write("array01: " + array01[i] + " array02 " + array02[i] + " <br/>");
            }

            //exercicio 2
            int[,] matrix = new int[5, 5];
            int[][] matrixJagged = new int[5][];

            int somaMatriz0 = 0;
            //imprime a matrix e preenche a matrixJagged
            for (int i = 0; i < 5; i++) {
                somaMatriz0 = 0;
                int[] temp = new int[5];
                for (int j = 0; j < 5; j++) {
                    matrix[j,i] = rnd.Next(1, 100);
                    somaMatriz0 += matrix[j, i];
                    temp[j] = matrix[j, i];                    
                }
                matrixJagged[i] = temp;
                Response.Write("Soma Matriz: " + somaMatriz0 +  "<br/>");
            }
            int somaColunaJagged;
            for (int i = 0; i < matrixJagged.Length; i++) {
                somaColunaJagged = 0;
                for (int j = 0; j < matrixJagged[i].Length; j++) {
                    somaColunaJagged += matrixJagged[j][i];
                    Response.Write(matrixJagged[j][i] + " ");
                }
                Response.Write("<br/>");
                Response.Write("soma coluna " + somaColunaJagged + " ");
                Response.Write("<br/>");
            }

            


        }
    }
}