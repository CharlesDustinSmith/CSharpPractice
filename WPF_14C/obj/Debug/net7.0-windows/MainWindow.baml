   M S B A M L   `   `   `  ����B  >WPF_14C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_14CWPF_14C  5   	       WPF_14C.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_14C     5   	     � Title$'  !Property, Data and Event Triggers��5   	   $	��450��63   $	��800��6@    � Icon$W QC:\Users\cdsmi\OneDrive\Documents\CSharp\WPF_14C\resource\government-building.png��5	   	   .��5
      �� .+�5   
   � .+�5      �� $��Hello Beloved World!��6   $��32(�64   $��Center=�6B   $��Center=�6_   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 � � �6G    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5   "   ��  � ��
 �  ��6M   �� 5   "    � ��$ 	Underline{�6D   6X   5      5      >5      5      � 5   
   .+�5      �� $��Hello Buddy��6   $��24(�6+   $��Center=�69   $��Center=�6V   ��5      �� 5      " ��6    5      :� 5       :� RoutedEvent$ 
MouseEnter��6+   [�5    "   �� 5!   &   .��5"   *   �� .��5#   .   W� 	 g� Duration$	 	0:0:0.500D�6>   
 �� TargetProperty$
 FontSize�6S   	 W� To 726x   6�   5$   +   5%   '   5'      :� 5(      $ 
MouseLeave��6+   [�5)   "   �� 5*   &   .��5+   *   �� .��5,   .   W� $	 	0:0:0.300D�6>   $
 FontSize�6S    246x   6�   5-   +   5.   '   50      52      54      55      �� 56   
   $��Center=�6   $��Center=�62   .+�57      �� -   5         ��Name$ cbHello��57      $��Is someone there?��6(   6F   �� 58      $��Center=�6   $��36(�65   ��59      �� 5:      " ��6   .�5;      ��  � ��$ No��61   6>   �� 5<       � ��
 �  ��6E    5=      �� 5>       �� Binding 6*   ��  �� ElementName$ cbHello�� �� Path$ 	IsChecked� �� Value true6b   .a�5?   "   ��  � ��$ 	Of Course��69   6M   �� 5@   "    � ��
 � � �6O   5A      5C      5E      5F      5G      5H      