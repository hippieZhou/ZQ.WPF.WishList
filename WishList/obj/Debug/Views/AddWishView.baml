   M S B A M L   `   `   `  ����C  ?WishList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WishListWishList  5      /clr-namespace:WishList.ViewsWishList.Views  5           WishList.Views.AddWishView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      %WLclr-namespace:WishList     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WishList.Views     5        � 	Resources  5
         WatermarkTextBoxStyle �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  WishButtonStyle ��Name��%�	  &	        &	 f    �� 5   
   " ��6.   .�5      ��  � ��$
 12,6q�6'   �� 5       � ��
 �����6+   �� 5       � ��
 �����6,   �� 5       � ��
 �   �6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 5��61   #��z��6B   #��z��6n   #��z��6�    . ._�5      �� $ PART_ContentHost��6+   $��6q�6E   |�.  $��Hidden=�6b   $��Disabled=�6�   $��Center=�6�   5      	 5      P� 5      
 � {� .  . �5   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5       P� 5!      
 �@J�IsMouseOver . . �5"   "   �� $ border��6@    � ��
 �����6T   5#      P� 5$      
 �@J�IsKeyboardFocused . . �5%   "   �� $ border��6@    � ��
 �����6T   5&      5(      5*       5+      ]� 5,       5-      �� 5.      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5/       �@��IsSelectionActive .  6A   ./�51      ��  �@��SelectionBrush# � /�67   52      54      �� 56   
   " ��6(   .�57      ��  � ��$ 12q�6'   �� 58       � ��$ 16(�6)   �� 59       � ��$ 36��6'   �� 5:       � ��
 �����6+   �� 5;       � ��
 ���� 6,   �� 5<       � ��
 �����6+   �� 5=       � ��$ 0q�60   �� 5>       � ��$ Center=�6;   �� 5?       � ��$ Center=�69   �� 5@       � ��$ 1q�6(   �� 5A       � �� 5B      �� 5C      " ��6&   .R�5D      �� $ border��6!   $ 5��61   #��z��6B   #��z��6d   #��z��6�   #��z��6�    . ._�5E      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5F      	 5G      P� 5H      
 �@��IsDefaulted . . �5I   "   �� $ border��6@   # � ��6T    � ��5J      P� 5K      
 �@J�IsMouseOver . . �5L   "   �� $ border��6?    � ��
 �����6S   5M      P� 5N      
 � �� . . �5O   "   �� $ border��6?    � ��
 �����6S   5P      P� 5Q      
 � {� .  . �5R   "   �� $ border��6?    � ��
 �����6S   5S      5U      5W      5X      5Y      .��5[      � ���#EAECF2 � RowDefinitions 5\   
   �� 5]      $��40 �6   �� 5^      $��* �6   .+�5`   
   � $��0��6   
�������.+�5a      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5b         WishList.ImageButton  $
��12,6q�6=      ImageSource$5 //WishList;component/Assets/ic_arrow_default.png��6K    J� Opacity$	 0.6Q�6�   ��6!   �� *	BackCmd+6�   �� 5c      $��添加愿望��6   $��Center=�6(   $��18(�6C   5d      5e      �� 5f   
   $��1��6   .+�5g      �� 
�������$	��100��6(   $	��100��65   $ 60��6A   $��24q�6S   ._�5h        $��Center=�6!   $��26��6>   $��Center=�6J   $7 1/WishList;component/Assets/ic_photo60_default.png��6e   5i      �� 5j       � ToolTip$ 我的愿望��6   #��[  6%   �� 5k      $ 愿望资金��6   #��[  6%   �� 5l      $ 备注��6   #��[  6#   �� 5n      $��许下愿望��6   #���  6$   5o      5p      5r      