   M S B A M L   `   `   `  ����F  BAboutWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AboutWindowAboutWindow  5   	   =#clr-namespace:AboutWindow.ViewModelAboutWindow.ViewModel  5   	       AboutWindow.GameClient   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )srcclr-namespace:AboutWindow     5   	   2vm#clr-namespace:AboutWindow.ViewModel     5   	     � Title$  Karli Cards Game Client��5   	    � WindowState$ 	Maximized=�6)   $	��356��6A   $	��754��6N    � DataContext 5      )   #AboutWindow.ViewModel.GameViewModel  5   
    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Close��5      6\     5   
   -   5        $ ApplicationCommands.Save��5      6[     5   
   -   5        $' !vm:GameViewModel.StartGameCommand��5      6d     5   
   -   5        $' !vm:GameViewModel.ShowAboutCommand��5      6d     5   
   -   5        $# vm:GameOptions.OptionsCommand��5      6`   .��5      � 
��� � � � RowDefinitions 5   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      �� $��56��6    �� Left$ 0��6    
 �� Top$ 0��60   $��UniformToFill=�6?   $��.\Images\Banner.png��6W   �� 5       �� Right$ 10��6   $ 13��6&   $��Karli Cards��66   ���	#FFF7EFEF$��Times New Roman)�6c   $��24(�6�   $
��Bold"�6�   5      ]� 5   
   $��1��6   $��0q�6!   .+�5      o� $��20��6   $	��Top=�6   
���   �$
��Bold"�6J   
�������.@�5      m� $��_File��6   
�������.@�5      m� $��_New Game...��6   
���   �$	��200��6H   	 m� Command$'	 !vm:GameViewModel.StartGameCommand��6T   m� 5       $��_Open��6   $	��200��6.   
���   �6:   m� 5!      $��_Save��6   $	��200��6.   
���   �$
	 Save��6M   
 m� Icon
 5"      �� 5#      $#��Images\base_floppydisk_32.png��6$   $��20��6K   5%      �� 5&      $	��145��6    
���   �6,   m� 5'      $��_Close��6   $	��200��6/   
���   �$	 Close��6N   5(      m� 5)      $��_Game��6   
���   �
�������.@�5*      m� $��_Undo��6   $
��Left=�6.   $	��145��6I   
���   �6U   5+      m� 5,      $��_Tools��6   
���   �
�������.@�5-      m� $��_Options��6   $
��Left=�61   $	��200��6L   
���   �$#	 vm:GameOptions.OptionsCommand��6k   5.      m� 5/      $
��Help��6   
���   �
�������.@�50      m� $��_About��6   $
��Left=�6/   $	��145��6J   
���   �$'	 !vm:GameViewModel.ShowAboutCommand��6i   51      52      53      ]� 54   
   $��2��6   .+�55      $   AboutWindow.CardsInHandControl  -   5          Name$ Player2Hand��55   %   $��Right=�6:   $	��380��6Q   $��Center=�56      $	��180��6&      PlayerOrientation$ Vertical=�62      Owner 57      �� *
Players[1]+   PlayerState 6(   �� *Players[1].State+   Game 6Q   ��   58      -   5        $ Player4Hand��58   %   $
��Left=�6:   $
��Left=�59      $	��380��6&   $��Center=�63   $	��180��6N   $ Vertical=�5:       6(   �� *
Players[3]+ 6E   �� *Players[3].State+ 5;      ��   5<      -   5        $ Player1Hand��5<   %   $	��Top=�6:   $��Center=�5=      $	��154��6(   $	��Top=�65   $	��380��6M   $ 
Horizontal=�5>       6*   �� *
Players[0]+ 5?      �� *Players[0].State+ 64   ��   5@      -	   5        $ Player3Hand��5@   %   $��Bottom=�6:   $��Center=�5A      $	��154��6(   $	��Top=�65   $	��380��6M   $ 
Horizontal=�5B       6*   �� *
Players[2]+ 5C      �� *Players[2].State+ 64   �� "   AboutWindow.GameDecksControl  5D      -
   5          Name$ 	GameDecks��5D   0   $	��180��6#      Deck 6C   �� *
GameDeck+   AvailableCard 5E      �� *CurrentAvailableCard+   CurrentPlayer 6:   �� *CurrentPlayer+   GameStarted 5F      �� *GameStarted+5G      5I      5J      