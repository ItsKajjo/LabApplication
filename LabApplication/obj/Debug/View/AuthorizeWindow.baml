   M S B A M L   `   `   `  ����I  ELabApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LabApplicationLabApplication  5   	   C&clr-namespace:LabApplication.ViewModelLabApplication.ViewModel  5   	   O,clr-namespace:LabApplication.Misc.ConvertersLabApplication.Misc.Converters  5   	   $    LabApplication.AuthorizeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LabApplication     5   	   <	viewmodel&clr-namespace:LabApplication.ViewModel     5   	   C
converters,clr-namespace:LabApplication.Misc.Converters     5   	   -   5          � Title$  Лаборатория��5   	   $	��450��6   $	��380��6*   $	��380��66   $	��330��6F    � WindowStartupLocation$ CenterScreen=�5   	   $��18(�5   	    � 	Resources 5          BooleanToVisibilityConverterA   ;LabApplication.Misc.Converters.BooleanToVisibilityConverter ( $InvertedBooleanToVisibilityConverter�   �LabApplication.Misc.Converters.BooleanConverter`1[[System.Windows.Visibility, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]   True   False��%e   &	        &	      �� 5   
   6'     5   
   $ 	Collapsed=�5   2   $ Visible=�5   2   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��125 �6   �� 5      $
��auto �6   �� 5      .+�5"   
   �� $��0��6   $��\Resources\LabLogo.png��6   $��10q�6=   �� 5$   
   $��1��6    �� Orientation$ Vertical=�6"   $��10, 5, 10, 5q�69   .+�5%      �� $��Авторизация��6   $��24(�6*   �� 5'      -   5        $��LoginTextBox��5'        TextBoxRoundCorners#��[ 5(      $��	0,10,0,10q�6F   ��5)      �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�G� 5+      -   5         G�Name$ PasswordBox��5+        PasswordBoxRoundCorners#��[ 5,      y�5.      �� *	IsChecked+	 �� ElementName$	 ShowPasswordChekBox��
 �� 	Converter#
 [ �� 50      -   5        $��PasswordUnmaskedTextBox��50      #��[ 51      ��52      �� *
Password+$ PropertyChanged=�y�53      �� *	IsChecked+$	 ShowPasswordChekBox��#
 [  �� 55      $.��(Неверный логин/пароль��6   
���  ��y�56      �� *InvalidAuth+#
 [  ]� 58      $��
0, 0, 0, 0q�6   .+�59      ��   HyperlinkUnderlineOnHover#��[ 6   $
��Left=�6O   �� 5:       �� TextDecorations$
 None{�6    .�67   Забыли пароль?6G   5;      �� 5=      -   5        $��ShowPasswordChekBox��5=      $��Right=�66   $#��Показать пароль��5>      $��Center=�65   5?      5@      �� 5B   
   $��2��6   $��Bottom=�6   $��Right=�69   $��10q�6U   $��
Войти��5C      $��20, 5, 20, 5q�6!   ���#ecf0f1���#3498db��5D      �� *LoginCommand+ 5E       �� 
TargetType �� Property �� Value��%^   '��       �� 5F      " ��6   .�5G      ��  �@��CornerRadius$ 7��65   5H      5I      5J      5K      5L      