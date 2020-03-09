using System;

namespace C__Projects {
    class Game {
        private String[, ] board;
        private String choice;
        private Boolean isPlayerOne;
        private Boolean winner = false;
        private String whoWon;
        private int turn;
        private Boolean isTie;
        public void startGame () {
            isPlayerOne = true;
            board = new String[3, 3] { 
                { "1", "2", "3" }, 
                { "4", "5", "6" }, 
                { "7", "8", "9" }
            };
            setBoard ();
            turn = 0;
            do {
                playTurn (isPlayerOne);
                Console.Clear();
                setBoard ();
                changePlayer (isPlayerOne);
                turn++;
                determineWinner (choice);

            } while (winner == false);
            if (isTie == false) {
                Console.WriteLine (whoWon + " has won!");
            } else {
                Console.WriteLine ("Tie!");
            }
        }
        private void setBoard () {
            Console.WriteLine ("     |      |      |" + "\n" +
                "  " + board[0, 0] + "  |   " + board[0, 1] + "  |   " + board[0, 2] + "  |\n" +
                "     |      |      |" + "\n" +
                "________________________\n" +
                "     |      |      |" + "\n" +
                "  " + board[1, 0] + "  |   " + board[1, 1] + "  |   " + board[1, 2] + "  |\n" +
                "     |      |      |" + "\n" +
                "________________________\n" +
                "     |      |      |" + "\n" +
                "  " + board[2, 0] + "  |   " + board[2, 1] + "  |   " + board[2, 2] + "  |\n" +
                "     |      |      |" + "\n"
            );
        }
        private void playTurn (Boolean player) {
            String p = "";
            if (player == true) p = "Player One";
            if (player == false) p = "Player Two";

            int num;
            Boolean isNum = false;
            while (isNum == false) {
                Console.WriteLine (p + " choose a spot!");
                choice = Console.ReadLine ();
                choice = choice.Trim ();
                isNum = int.TryParse (choice, out num);
                if (isNum == false) Console.WriteLine ("Incorrect input try again!");
            }
            determineSpot (choice);
        }
        private void determineSpot (String choice) {
            String piece = "";
            if (isPlayerOne == true) piece = "X";
            if (isPlayerOne == false) piece = "O";
            if (choice == "1" && board[0, 0] == "1") {
                board[0, 0] = piece;
            } else if (choice == "2" && board[0, 1] == "2") {
                board[0, 1] = piece;
            } else if (choice == "3" && board[0, 2] == "3") {
                board[0, 2] = piece;
            } else if (choice == "4" && board[1, 0] == "4") {
                board[1, 0] = piece;
            } else if (choice == "5" && board[1, 1] == "5") {
                board[1, 1] = piece;
            } else if (choice == "6" && board[1, 2] == "6") {
                board[1, 2] = piece;
            } else if (choice == "7" && board[2, 0] == "7") {
                board[2, 0] = piece;
            } else if (choice == "8" && board[2, 1] == "8") {
                board[2, 1] = piece;
            } else if (choice == "9" && board[2, 2] == "9") {
                board[2, 2] = piece;
            } else {
                Console.WriteLine ("Spot taken, try again!");
                playTurn (isPlayerOne);
            }
        }
        private void determineWinner (String choice) {
            // check row 1
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2]) {
                if (board[0, 0] == "X") whoWon = "Player One";
                if (board[0, 0] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check row 2
            if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2]) {
                if (board[1, 0] == "X") whoWon = "Player One";
                if (board[1, 0] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check row 3
            if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2]) {
                if (board[2, 0] == "X") whoWon = "Player One";
                if (board[2, 0] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check column 1
            if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0]) {
                if (board[0, 0] == "X") whoWon = "Player One";
                if (board[0, 0] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check column 2
            if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1]) {
                if (board[0, 1] == "X") whoWon = "Player One";
                if (board[0, 1] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check column 3
            if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2]) {
                if (board[0, 2] == "X") whoWon = "Player One";
                if (board[0, 2] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check left diagonal
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2]) {
                if (board[0, 0] == "X") whoWon = "Player One";
                if (board[0, 0] == "O") whoWon = "Player Two";
                winner = true;
            }
            // check right diagonal
            if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0]) {
                if (board[0, 2] == "X") whoWon = "Player One";
                if (board[0, 2] == "O") whoWon = "Player Two";
                winner = true;
            }
            if (turn == 9 && winner == false){
                isTie = true;
                winner = true;
            } 
        }
        private void changePlayer (Boolean player) {
            if (player == true) {
                isPlayerOne = false;
            } else if (player == false) {
                isPlayerOne = true;
            }
        }
    }
}
