   M S B A M L   `   `   `  ����F  BAboutWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AboutWindowAboutWindow  5          AboutWindow.CardControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )srcclr-namespace:AboutWindow     5      -   5          >�Name$  UserControl��5      $	��154��6   $	��100��6    � 	Resources 5	      #   AboutWindow.RankNameConverter   rankConverter  SuitTemplate �� 
TargetType  	SuitImage �� Triggers �� Binding �� ElementName �� Path �� Value �� Property	 �� Value��%�  &	        &	      &	 I       5
   
   6    �� 5   
   .R�5      �� ��6   �� 5      �� 5   
   " ��6    5      �� 5       6   �� $ UserControl��$
 Suit� Club6U   .a�5      ��  � ��$	 Images\Clubs.png��6/   5      �� 5       6   �� $ UserControl��$
 Suit�	 Heart6U   .a�5      ��  � ��$	 Images\Hearts.png��6/   5      �� 5       6   �� $ UserControl��$
 Suit� Diamond6U   .a�5      ��  � ��$	 Images\Diamonds.png��6/   5      �� 5       6   �� $ UserControl��$
 Suit�	 Spade6U   .a�5      ��  � ��$	 Images\Spades.png��6/   5      5      5      .��5      � .+�5    
   �� 
 �� RadiusX$

 12.5��6&    �� RadiusY$
 12.5��65   ��6   Z� ��5!      �� 5"       �� EndPoint$ 0.47,-0.167&�6&    �� 
StartPoint$ 	0.86,0.92&�6=   .��5#      �  � Color$ 	#FFD1C78F��6#    � Offset$ 0Q�65   � 5$      $ 	#FFFFFFFF��6#   $ 1Q�65   5%       J� Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         	Direction$	 145Q�6#      
BlurRadius$ 10Q�63      ShadowDepth$ 0Q�6C   5*      �� 5+   
   -   5         ��Name$ 	SuitLabel��5+      #���  5-      $��Center=�5.      $��Center=�6   $��	8,51,8,60q�5/      ��5,      �� $
 Suit�$ UserControl�� �� Mode$ Default=�5/      �� 50   
   -   5        $ 	RankLabel��50       K� ZIndex$ 1��6#   #���  53      $
��Left=�54      $	��Top=�6   $��8,8,0,0q�55      ��51      �� $
 Rank�$ UserControl��$ Default=� �� 	Converter# [  55      �� 56   
   -   5        $ RankLabelInverted��56      #���  59      $��Right=�5:      $��Bottom=�6   $��0,0,8,8q�5;       J� RenderTransformOrigin$ 0.5,0.5&�6   ��57      �� $
 Rank�$ UserControl��$ Default=�# [  z�5<      �� 5=       �� Angle$	 180Q�6"   5?      �� 5@   
   -   5        $��TopRightImage��5@      #��[ 6%   $��	12,12,8,0q�5A      $��Right=�6   $	��Top=�60   $
��18.5��5B      $
��18.5��6   $��UniformToFill=�6   �� 5C   
   -   5        $��BottomLeftImage��5C      #��[ 6'   $��	12,0,8,12q�5D      $
��Left=�6   $��Bottom=�6/   $
��18.5��5E      $
��18.5��6   $��UniformToFill=�6   $ 0.5,0.5&�5F      z�5G      �� 5H      $	 180Q�6"   5J      F� 5K   
   ���	#FFFFFFFF �� Stretch$
 Fill=�6    $��0,0,35.218,-0.077q�5L      �������2
�	��2
�H'�Ӓ�s�nQf�L�`@@��ӾT����
�	n�֤	���Ѡ� ��Ә�, ���\��\��\��-р\����Ӏ\�ח_��,�2
���2
��5K   /   Z�  J� OpacityMask 5P      �� 5Q      $ 0.957,1.127&�6&   $ 0,-0.06&�6=   .��5R      � $ 	#FF000000��6#   $ 0Q�65   � 5S      $ 	#00FFFFFF��6#   $ 1Q�65   5T      5V      5W      5X      