using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Save_The_Humans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
        bool humanCaptured = false;
        int alienNumber = 0;
        int levelNumber = 1;

        public MainWindow()
        {
            InitializeComponent();

            gameOverText.Text = "Welcome";

            enemyTimer.Tick += enemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += targetTimer_Tick;
            targetTimer.Interval += TimeSpan.FromSeconds(.1);
        }

        void targetTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value >= progressBar.Maximum)
                endTheGame();
        }

        private void endTheGame()
        {
            if(!playArea.Children.Contains(gameOverText))
            {
                enemyTimer.Stop();
                targetTimer.Stop();
                humanCaptured = false;
                startButton.Visibility = Visibility.Visible;
                gameOverText.Text = "Game Over";
                playArea.Children.Add(gameOverText);
            }
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            addEnemy();

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startGame();
            alienNumber = 0;
            alienAmount.Text = alienNumber.ToString();
            levelNumber = 1;
            level.Text = levelNumber.ToString();
        }

        private void startGame()
        {
            human.IsHitTestVisible = true;
            humanCaptured = false;
            progressBar.Value = 0;
            startButton.Visibility = Visibility.Collapsed;
            playArea.Children.Clear();
            playArea.Children.Add(target);
            playArea.Children.Add(human);
            enemyTimer.Start();
            targetTimer.Start();
            alienNumber = 0;
        }

        private void addEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArea.ActualWidth - 100, "(Canvas.Left)");
           //double myInt = playArea.ActualHeight; //random.Next((int)playArea.ActualHeight);
            //text.Text = myInt.ToString();
            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight-100), 
                random.Next((int)playArea.ActualHeight - 100), "(Canvas.Top)");
            playArea.Children.Add(enemy);
            alienNumber++;
            alienAmount.Text = alienNumber.ToString();

            enemy.MouseEnter += enemy_MouseEnter;
        }

        void enemy_MouseEnter(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
                endTheGame();
        }

        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyToAnimate)
        {
            Storyboard storyboard = new Storyboard() {AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4,6))),
            };
            Storyboard.SetTarget(animation, enemy);
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));
            storyboard.Children.Add(animation);
            storyboard.Begin();


        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void human_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(enemyTimer.IsEnabled)
            {
                humanCaptured = true;
                human.IsHitTestVisible = false;
            }
        }

        private void target_MouseEnter(object sender, MouseEventArgs e)
        {
            if(targetTimer.IsEnabled && humanCaptured)
            {
                progressBar.Value = 0;
                levelNumber++;
                level.Text = levelNumber.ToString();
                Canvas.SetLeft(target, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(target, random.Next(100, (int)playArea.ActualHeight - 100));
                Canvas.SetLeft(human, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(human, random.Next(100, (int)playArea.ActualHeight - 100));
                humanCaptured = false;
                human.IsHitTestVisible = true;
            }
        }

        private void playArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
            {
                Point pointerPosition = e.GetPosition(null);
                Point relativePosition = grid.TransformToVisual(playArea).Transform(pointerPosition);
                if((Math.Abs(relativePosition.X - Canvas.GetLeft(human)) > human.ActualWidth*3)||
                    (Math.Abs(relativePosition.Y - Canvas.GetTop(human)) > human.ActualHeight * 3))
                {
                    humanCaptured = false;
                    human.IsHitTestVisible = true;
                }
                else
                {
                    Canvas.SetLeft(human, relativePosition.X - human.ActualWidth / 2);
                    Canvas.SetTop(human, relativePosition.Y - human.ActualHeight / 2);
                }
            }
        }

        private void playArea_MouseLeave(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
                endTheGame();
        }
    }
}
