   M S B A M L   `   `   `  ����   Save The Humans     Save_The_Humans.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Save The Humans��$	��700��$
��1000��
���   � � 
ResizeMode$ NoResize=� � WindowStartupLocation$ Manual=� � Left$ 0��
 � Top$ 0�� � 	Resources    EnemyTemplate �� 
TargetType �� Angle �� Orientation	 J� RenderTransformOrigin
 �� AngleX T� X��%�  &	        �� " ��.R�� .+�A� 
�������$	��100��
���   �$��75��z�V� .~��� �� �� $ -2.226Q�T� �� $��22,20,52,45q�$ Vertical=�.+�A� 
���   �$��Center=�$��35��
���   �$	��Top=�$��25��$	 
0.373,0.45&�$��0,0,1,0q�z�V� .~��� �� $
 10Q��� T� �� $��52,20,22,45q�$ Vertical=�.+�A� 
���   �$��Center=�$��35��$��0,0,1,0q�
���   �$	��Top=�$��25��$	 1.022,0.914&�z�V� .~��� �� $	
 -10Q��� T� $ -2.555Q�.��� -    �Name$
 grid��$	��661��$	��Top=�$
��Left=�$
��1000��$��0,0,-6,0q�
���   � � ColumnDefinitions �� $	��140 ��� �� $	��160 � � RowDefinitions �� �� $	��150 �.+��� -    ��Name$ startButton��$��Start!��$��53,75,55,55q�$��1��$��Center=�$��Center=�$	 0.031,0&�� -    �Name$ progressBar��$��1��$��1��$��20��$��	0,94,0,36q��� $��2��$ Vertical=�$��1��$��Center=�$��Center=�$��
0,10,20,16q�.+��� $
��Wrap=�$��Avoid These��$	 0,0.625&�$��18(�$��Center=�$��Center=�
�������
���   ��� $��ContentControl��$��Center=�$
��20,0q�$��Center=�#���   �� -    ��Name$ playArea��$��Center=�$	��Top=�$��3��$
��1000��$	��501������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF17F30D�� � Offset$ 1Q�� $ 	#FF7A06DA��.+��� -    ��Name$ gameOverText��$��Center=�$
��Wrap=�$��	Game Over��$��Center=�$��Ariel)�$
��Bold"�$��Italic$�$	��100(� �� Left$	 235��
 �� Top$	 165���� -    ��Name$ human��$ Vertical=�$	 855��$��Center=�$��Center=�$	 0.5,0.5&�$	 128��$��35��z�V� .~���  �� ScaleX$ -1Q��� �� $ 178.428Q�T� .+��� 
�������$��25��$��10��A� 
�������$��10��$��10���� -    ��Name$ target��$��Center=�$��50��$��Center=�$��50��$	 0.5,0.5&�$	 335��$	 370��z�V� .~��� �� �� $	 -45Q�T� ���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF271A1A��$ 0.009Q�� $ 	#FFECE8E8��$ 1Q��� -   $ alienAmount��$��1��$
��Left=�$��
155,41,0,0q�$��1��$
��Wrap=�$	��Top=����	#FFF70606$��25(�$��0���� $��1��$
��Left=�$��80,9,0,0q�$��1��$
��Wrap=�$��Amount of Aliens:��$	��Top=����	#FFFFFDFD$��20(��� -	   $ 	levelText��$��1��$
��Left=�$��
485,10,0,0q�$��1��$
��Wrap=�$��You are on Level:��$	��Top=����	#FFFBF9F9$��20(��� -
   $ level��$��1��$
��Left=�$��
550,42,0,0q�$��1��$
��Wrap=�$��1��$	��Top=����	#FF9811F5$��25(�