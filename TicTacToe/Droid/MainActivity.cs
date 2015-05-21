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
	[Activity (Label = "tictactoe.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new App ());
			SetContentView (Resource.Layout.Main);

			Context context = this;

			Button button1 = FindViewById<Button> (Resource.Id.button1);
			Button button2 = FindViewById<Button> (Resource.Id.button2);
			Button button3 = FindViewById<Button> (Resource.Id.button3);
			Button button4 = FindViewById<Button> (Resource.Id.button4);
			Button button5 = FindViewById<Button> (Resource.Id.button5);
			Button button6 = FindViewById<Button> (Resource.Id.button6);
			Button button7 = FindViewById<Button> (Resource.Id.button7);
			Button button8 = FindViewById<Button> (Resource.Id.button8);
			Button button9 = FindViewById<Button> (Resource.Id.button9);
			Button resetButton = FindViewById<Button> (Resource.Id.resetButton);



			AlertDialog.Builder winMessage = new AlertDialog.Builder(context);
			AlertDialog.Builder loseMessage = new AlertDialog.Builder(context);
			AlertDialog.Builder tieMessage = new AlertDialog.Builder(context);

			winMessage.SetTitle("You win!!");
			loseMessage.SetTitle("You lose!!");
			tieMessage.SetTitle("You tie!");

			winMessage.SetMessage("You've won this game! Click Play again!");
			winMessage.SetCancelable(false);
			winMessage.SetPositiveButton("Play again", (s, e) => { });
			winMessage.Create();
			loseMessage.SetMessage("You've lost! Click Play again!");
			loseMessage.SetCancelable(false);
			loseMessage.SetPositiveButton("Play again", (s, e) => { });
			loseMessage.Create();
			tieMessage.SetMessage("You tie. But if you're not first, you're last. So you lose.");
			tieMessage.SetCancelable(false);
			tieMessage.SetPositiveButton("Play again", (s, e) => { });
			tieMessage.Create();

			button1.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button1.Text == "")
					{
						gameHandler.changeButtonText(button1,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();

				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}

			};
				
			button2.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button2.Text == "")
					{
						gameHandler.changeButtonText(button2,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();
				
				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};
				
			button3.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button3.Text == "")
					{
						gameHandler.changeButtonText(button3,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();
				
				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};

			button4.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button4.Text == "")
					{
						gameHandler.changeButtonText(button4,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();
				
				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};
				
			button5.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button5.Text == "")
					{
						gameHandler.changeButtonText(button5,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();
				
				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};
				
			button6.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button6.Text == "")
					{
						gameHandler.changeButtonText(button6,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();

				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};

			button7.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button7.Text == "")
					{
						gameHandler.changeButtonText(button7,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();

				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};

			button8.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button8.Text == "")
					{
						gameHandler.changeButtonText(button8,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();
				
				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};

			button9.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					if (button9.Text == "")
					{
						gameHandler.changeButtonText(button9,"X");
					}
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				gameHandler.computerMove();
				gameHandler.updateView(FindViewById (Resource.Id.contentView));
				String winner = gameHandler.checkWin();

				if (winner == "player")
				{
					updatePlayerScore(1);
					winMessage.Show();
					gameHandler.resetBoard();
				}else if (winner == "computer")
				{
					updateComputerScore(1);
					loseMessage.Show();
					gameHandler.resetBoard();
				}else if (gameHandler.isBoardFull())
				{
					tieMessage.Show();
					gameHandler.resetBoard();
				}
			};

			resetButton.Click += delegate 
			{
				GameHandler gameHandler = new GameHandler (FindViewById (Resource.Id.contentView));
					gameHandler.resetBoard();
					resetScore();

			};

		}

		protected override void OnStop  ()
		{
			resetScore();
		}

		private void resetScore()
		{
			TextView computerCurrentScore = (TextView) FindViewById(Resource.Id.computerScore);
			computerCurrentScore.Text = ("0");

			TextView playerCurrentScore = (TextView) FindViewById(Resource.Id.playerScore);
			playerCurrentScore.Text = ("0");
		}

		private void updatePlayerScore(int point)
		{
			TextView currentScore = (TextView) FindViewById(Resource.Id.playerScore);
			int newScore = int.Parse(currentScore.Text);
			newScore++;
			currentScore.Text = (newScore.ToString());

		}

		private void updateComputerScore(int point)
		{
			TextView currentScore = (TextView) FindViewById(Resource.Id.computerScore);
			int newScore = int.Parse(currentScore.Text);
			newScore++;
			currentScore.Text = (newScore.ToString());
		}
	}
}

