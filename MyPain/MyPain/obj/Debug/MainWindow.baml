   M S B A M L   `   `   `  ����A  =MyPain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyPainMyPain  5   	       MyPain.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyPain     5   	     � Title$  My Pain��5   	   $	��450��6   $	��800��6&    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$	 New��5
      6T     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6U     5   
   -   5        $	 Cut��5      6'     5   
   -   5        $
 Copy��5      6(     5   
   -   5        $ Paste��5      6)     5   
   -   5        $ Select��5      6W   .��5      ]� .+�5   
   `� $	��Top=�6    `� IsLocked . .�5      c� .@�5      �� $	��New��6   $	��New��6'   �� 5      $
��Open��6   $
��Open��6(   �� 5      -   5         ��Name$ saveBtn��5      $
��Save��6*    � ToolTip$ 	Save file��69   .��5      �� $��Pictures\FloppyDisk.png��6   $��25��6=   5      5      c� 5      .@�5      �� -	   5        $ cutBtn��5      $	��Cut��6)   $ Cut to clipboard��67   .��5      �� $��Pictures\Scissors.png��6   $��25��6;   5      �� 5       -
   5        $ copyBtn��5       $
��Copy��6*   $ Copy to clipboard��69   .��5!      �� $��Pictures\Papers.png��6   $��25��69   5"      �� 5#      -   5        $ pasteBtn��5#      $��Paste��6+   $ Paste from clipboard��6;   .��5$      �� $��Pictures\Clipboard.png��6   $��25��6<   5%      �� 5&      -   5        $ 	selectBtn��5&      $��Select��6,   $ Select��6=   .��5'      �� $��Pictures\Rotate.png��6   $��25��69   5(      5)      c� 5+      .@�5,      �� -   5        $ 	pencilBtn��5,      $ Pencil��6,   .��5-      �� $��Pictures\Pencil.png��6   $��25��69   5.      �� 5/      -   5        $ 	eraserBtn��5/      $ Eraser��6,   .��50      �� $��Pictures\Eraser.png��6   $��25��69   51      �� 52      -   5         ��Name$ brushColours��52      ��53      �� 54      .R�55      ��  �� Orientation$ 
Horizontal=�6)   .+�56   "   �� $��16��6B   $��16��6M   ��6,   �� *Name+6M   57      58      5:      �� 5;      -   5        $ brushSizeBox��5;      5<      5=      5>      �� 5?   
   -   5         ��Name$ 	paintArea��5?      	 �� 
Background
	 ���� $	��790��6@   $	��385��6L   5@      5A      