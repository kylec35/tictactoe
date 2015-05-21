using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace tictactoe.Droid
{
	public class GameHandler
	{
		const String computerGamePiece = "O";
		private View gameView;
		Button button1,button2,button3,button4,button5,button6,button7,button8,button9;
		String button1Text,button2Text,button3Text,button4Text,button5Text,button6Text,button7Text,button8Text,button9Text;

		public GameHandler (View v)
		{
			initializeVariables(v);
		}

		public void initializeVariables(View v)
		{
			this.gameView = v;	
			this.button1 = gameView.FindViewById<Button> (Resource.Id.button1);
			this.button2 = gameView.FindViewById<Button> (Resource.Id.button2);
			this.button3 = gameView.FindViewById<Button> (Resource.Id.button3);
			this.button4 = gameView.FindViewById<Button> (Resource.Id.button4);
			this.button5 = gameView.FindViewById<Button> (Resource.Id.button5);
			this.button6 = gameView.FindViewById<Button> (Resource.Id.button6);
			this.button7 = gameView.FindViewById<Button> (Resource.Id.button7);
			this.button8 = gameView.FindViewById<Button> (Resource.Id.button8);
			this.button9 = gameView.FindViewById<Button> (Resource.Id.button9);

			this.button1Text = button1.Text;
			this.button2Text = button2.Text;
			this.button3Text = button3.Text;
			this.button4Text = button4.Text;
			this.button5Text = button5.Text;
			this.button6Text = button6.Text;
			this.button7Text = button7.Text;
			this.button8Text = button8.Text;
			this.button9Text = button9.Text;
				
		}

		public void computerMove()
		{
			if (button1Text == "O" && button2Text == "O" && button3Text == "")
			{
				changeButtonText(button3, computerGamePiece);
			}else if (button4Text == "O" && button5Text == "O" && button6Text == "")
			{
				changeButtonText(button6, computerGamePiece); 
			}else if (button7Text == "O" && button8Text == "O" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button1Text == "O" && button4Text == "O" && button7Text == "")
			{
				changeButtonText(button7, computerGamePiece);
			}else if (button2Text == "O" && button5Text == "O" && button8Text == "")
			{
				changeButtonText(button8, computerGamePiece);
			}else if (button3Text == "O" && button6Text == "O" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button1Text == "O" && button5Text == "O" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button3Text == "O" && button5Text == "O" && button7Text == "")
			{
				changeButtonText(button7, computerGamePiece);
			}else if (button1Text == "O" && button2Text == "" && button3Text == "O")
			{
				changeButtonText(button2, computerGamePiece);
			}else if (button4Text == "O" && button5Text == "" && button6Text == "O")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button7Text == "O" && button8Text == "" && button9Text == "O")
			{
				changeButtonText(button8, computerGamePiece);
			}else if (button1Text == "O" && button4Text == "" && button7Text == "O")
			{
				changeButtonText(button4, computerGamePiece);
			}else if (button2Text == "O" && button5Text == "" && button8Text == "O")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button3Text == "O" && button6Text == "" && button9Text == "O")
			{
				changeButtonText(button6, computerGamePiece);
			}else if (button1Text == "O" && button5Text == "" && button9Text == "O")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button3Text == "O" && button5Text == "" && button7Text == "O")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button1Text == "X" && button5Text == "X" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button3Text == "X" && button5Text == "X" && button7Text == "")
			{
				changeButtonText(button7, computerGamePiece);
			}else if (button1Text == "X" && button4Text == "X" && button7Text == "")
			{
				changeButtonText(button7, computerGamePiece);
			}else if (button2Text == "X" && button5Text == "X" && button8Text == "")
			{
				changeButtonText(button8, computerGamePiece);
			}else if (button3Text == "X" && button6Text == "X" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button1Text == "X" && button2Text == "X" && button3Text == "")
			{
				changeButtonText(button3, computerGamePiece);
			}else if (button4Text == "X" && button5Text == "X" && button6Text == "")
			{
				changeButtonText(button6, computerGamePiece);
			}else if (button7Text == "X" && button8Text == "X" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button1Text == "X" && button4Text == "" && button7Text == "X")
			{
				changeButtonText(button4, computerGamePiece);
			}else if (button2Text == "X" && button5Text == "" && button8Text == "X")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button3Text == "X" && button6Text == "" && button9Text == "X")
			{
				changeButtonText(button6, computerGamePiece);
			}else if (button1Text == "X" && button2Text == "" && button3Text == "X")
			{
				changeButtonText(button2, computerGamePiece);
			}else if (button4Text == "X" && button5Text == "" && button6Text == "X")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button7Text == "X" && button8Text == "" && button9Text == "X")
			{
				changeButtonText(button8, computerGamePiece);
			}else if (button1Text == "X" && button5Text == "" && button9Text == "X")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button3Text == "X" && button5Text == "" && button7Text == "X")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button2Text == "X" && button3Text == "X" && button1Text == "")
			{
				changeButtonText(button1, computerGamePiece);
			}else if (button5Text == "X" && button6Text == "X" && button4Text == "")
			{
				changeButtonText(button4, computerGamePiece);
			}else if (button4Text == "X" && button7Text == "X" && button1Text == "")
			{
				changeButtonText(button1,computerGamePiece);
			}else if (button5Text == "X" && button8Text == "X" && button2Text == "")
			{
				changeButtonText(button2, computerGamePiece);
			}else if (button6Text == "X" && button9Text == "X" && button3Text == "")
			{
				changeButtonText(button3, computerGamePiece);
			}else if (button5Text == "X" && button9Text == "X" && button1Text == "")
			{
				changeButtonText(button1, computerGamePiece);
			}else if (button5Text == "X" && button7Text == "X" && button3Text == "")
			{
				changeButtonText(button3, computerGamePiece);
			}else if (button5Text == "O" && button1Text == "")
			{
				changeButtonText(button1, computerGamePiece);
			}else if (button5Text == "O" && button3Text == "")
			{
				changeButtonText(button3, computerGamePiece);	
			}else if (button5Text == "O" && button7Text == "")
			{
				changeButtonText(button7, computerGamePiece);
			}else if (button5Text == "O" && button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button1Text == "X" && button5Text == "")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button3Text == "X" && button5Text == "")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button7Text == "X" && button5Text == "")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button9Text == "X" && button5Text == "")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button1Text == "O" && button2Text == "")
			{
				changeButtonText(button2, computerGamePiece);
			}else if (button1Text == "O" && button4Text == "")
			{
				changeButtonText(button4, computerGamePiece);
			}else if (button3Text == "O" && button2Text == "")
			{
				changeButtonText(button2, computerGamePiece);
			}else if (button3Text == "O" && button6Text == "")
			{
				changeButtonText(button6, computerGamePiece);
			}else if (button7Text == "O" && button4Text == "")
			{
				changeButtonText(button4, computerGamePiece);
			}else if (button7Text == "O" && button8Text == "")
			{
				changeButtonText(button8, computerGamePiece);
			}else if (button9Text == "O" && button6Text == "")
			{
				changeButtonText(button6, computerGamePiece);
			}else if (button9Text == "O" && button8Text == "")
			{
				changeButtonText(button8, computerGamePiece);
			}else if (button5Text == "")
			{
				changeButtonText(button5, computerGamePiece);
			}else if (button1Text == "")
			{
				changeButtonText(button1, computerGamePiece);
			}else if (button3Text == "")
			{
				changeButtonText(button3, computerGamePiece);
			}else if (button7Text == "")
			{
				changeButtonText(button7, computerGamePiece);
			}else if (button9Text == "")
			{
				changeButtonText(button9, computerGamePiece);
			}else if (button2Text == "")
			{
				changeButtonText(button2, computerGamePiece);
			}else if (button4Text == "")
			{
				changeButtonText(button4, computerGamePiece);
			}else if (button6Text == "")
			{
				changeButtonText(button6, computerGamePiece);
			}else if(button8Text == ""){
				changeButtonText(button8, computerGamePiece);
			}
				
		}

		public String checkWin()
		{
			String winner = "none";

			if (button1Text == "X" && button2Text == "X" && button3Text == "X"){
				winner = "player";
			}else if (button4Text == "X" && button5Text == "X" && button6Text == "X")
			{
				winner = "player";
			}else if (button7Text == "X" && button8Text == "X" && button9Text == "X")
			{
				winner = "player";
			}else if (button1Text == "X" && button4Text == "X" && button7Text == "X")
			{
				winner = "player";
			}else if (button2Text == "X" && button5Text == "X" && button8Text == "X")
			{
				winner = "player";
			}else if (button3Text == "X" && button6Text == "X" && button9Text == "X")
			{
				winner = "player";
			}else if (button1Text == "X" && button5Text == "X" && button9Text == "X")
			{
				winner = "player";
			}else if (button3Text == "X" && button5Text == "X" && button7Text == "X")
			{
				winner = "player";
			}else if (button1Text == "O" && button2Text == "O" && button3Text == "O")
			{
				winner = "computer";
			}else if (button4Text == "O" && button5Text == "O" && button6Text == "O")
			{
				winner = "computer";
			}else if (button7Text == "O" && button8Text == "O" && button9Text == "O")
			{
				winner = "computer";
			}else if (button1Text == "O" && button4Text == "O" && button7Text == "O")
			{
				winner = "computer";
			}else if (button2Text == "O" && button5Text == "O" && button8Text == "O")
			{
				winner = "computer";
			}else if (button3Text == "O" && button6Text == "O" && button9Text == "O")
			{
				winner = "computer";
			}else if (button1Text == "O" && button5Text == "O" && button9Text == "O")
			{
				winner = "computer";
			}else if (button3Text == "O" && button5Text == "O" && button7Text == "O")
			{
				winner = "computer";
			}

			return winner;
		}

		public bool isBoardFull()
		{
			bool isFull = true;

			if (button1Text == ""){
				isFull = false;
			}else if (button2Text == ""){
				isFull = false;
			}else if (button3Text == ""){
				isFull = false;
			}else if (button4Text == ""){
				isFull = false;
			}else if (button5Text == ""){
				isFull = false;
			}else if (button6Text == ""){
				isFull = false;
			}else if (button7Text == ""){
				isFull = false;
			}else if (button8Text == ""){
				isFull = false;
			}else if (button9Text == ""){
				isFull = false;
			}

			return isFull;
		}

		public void resetBoard()
		{
			button1.Text = string.Format ("");
			button2.Text = string.Format ("");
			button3.Text = string.Format ("");
			button4.Text = string.Format ("");
			button5.Text = string.Format ("");
			button6.Text = string.Format ("");
			button7.Text = string.Format ("");
			button8.Text = string.Format ("");
			button9.Text = string.Format ("");
		}

		public void changeButtonText(Button button, String text)
		{
			button.Text = string.Format (text);
		}

		public void updateView (View v)
		{
			initializeVariables(v);
		}
	}
}

