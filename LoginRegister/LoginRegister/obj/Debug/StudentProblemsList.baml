   M S B A M L   `   `   `  ����H  DLoginRegister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LoginRegisterLoginRegister  5      '    !LoginRegister.StudentProblemsList   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:LoginRegister     5        N� Title$  StudentProblemsList��5	      .��5      � -   5         �Name$ g��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��7* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $
��lstv��5      $��6��6   $��1��63   $��0,0,0,91q�6@    �� View 5      �� 5      .P�5      �� $��
Class Name��6\    �� Width$	 100��6p    �� DisplayMemberBinding 6%   ��  �� Path$ Classs.ClassName�6p   �� 5       $��Student Name��6]   $	 100��6s    6%   �� $ Student.FirstName�6s   �� 5"      $��	Tool Name��6d   $	 100��6w    6%   �� $ Tools.ToolName.ToolName1�6w   �� 5$      $��Description��6W   $	 100��6l    6%   �� $ Description�6l   �� 5%      $��Prob ID��6N   $	 100��6_    6%   �� $ Id�6_   �� 5&      $��Solving Time��6W   $	 100��6m    6%   �� $ SolvingTime�6m   �� 5'      $��	Is Solved��6T   $	 100��6g    6%   �� $ Issolved�6g   5(      5,      �� 5-   
   -   5         ��Name$ button7��5-      $	��160��5.      $��36��5/      $��Center=�50      $	��Top=�51      $
��Back��53      
����  �
�������$��106,332,0,0q�6I   $��1��6^   $��2��6k   	� 54   
   -   5        	 	�Name$		 rb1��54   Y   $��Center=�6   $��Center=�63   $��60��6N   
 	� 	GroupName$
 Issolved��6f   $��30,14,44,14q�6�   $��4��6�   .��6�   Yes6�   	� 55   
   -   5        $		 rb2��55   N   $��Center=�6   $��Center=�63   $
 Issolved��6[   $��23,14,25,15q�6�   $��5��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   No56      �� 57   
   -   5         ��Name$
 cmb1��57   K   $��Center=�6   $��Center=�60   $	��100��6Y   $��20��6e   $��0��6r   $��23,18,10,18q�6�   $��3��6�   59      �� 5:   
   -   5        $
 cmb2��5:   K   $��Center=�6   $��Center=�60   $	��100��6Y   $��20��6e   $��0��6r   $��10,18,24,18q�6   $��2��6�   5<      �� 5=   
   -   5        $��Center=�5=      $��Center=�6.   $��65��6I   $��חפש��6T   $��1��6b   $��30��6r   $��33,14,35,12q�6�   $ 	0.431,0.6&�6�   5?      �� 5@   
   -	   5        $��Center=�5@      $��Center=�6.   $��65��6I   $��
איפוס��6T   $��30��6d   $��35,12,33,14q�6�   5B      �� 5C   
   $	��30 ��6   $��2��6!   $��4��65   $��90,12,108,14q�6E   $��20(�6[   	solved?6s   5F      5G      