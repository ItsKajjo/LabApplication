   M S B A M L   `   `   `  ����I  ELabApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LabApplication.ViewLabApplication.View  5   	   C&clr-namespace:LabApplication.ViewModelLabApplication.ViewModel  5   	   $    LabApplication.View.HomeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:LabApplication.View     5   	   <	viewmodel&clr-namespace:LabApplication.ViewModel     5   	   -   5          � Title$?  9Лаборатория: Панель управления��5
   	   $	��600��60   $
��1000��6=   $	��600��6J   $	��700��6Z    � WindowStartupLocation$ CenterScreen=�5   	   $��18(�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �� $��\Resources\Logo.png��6   $
��Left=�61   $��5q�6L   �� 5      $��Center=�6   $#��Панель действий��5      $��30(�6(   $��Verdana)�66   ���#fc60606K   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� $��45��6   $��45��6%    �� CornerRadius$ 90��60   $��5q�6B   ��5      �� 5       j� Stretch$
 Fill=�6%    �� ImageSource$. (\Resources\ProfilePicturePlaceholder.png��64   5      �� 5!      $ Vertical=�6   $��
0, 5, 0, 5q�64   .+�5"      �� $��1q�6A   $
��Bold"�6L   ��6    �� *CurrentUserName+6L   �� 5#      $��1q�6A   
���iii���6    �� *CurrentUserRole+6L   5$      �� 5%      $��10q�6   $��5q�6%   
����� ���5&      �� *Logout+.��5'      �� $��\Resources\exit.png��6    � 	Resources 5(       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 5)      " ��6    .�5*      �� 	 �@��CornerRadius$
 5��6=   5+      5,      5-      5.      5/      �� 51   
   $��1��6   $	��Top=�6!   ]� 54   
   $��1��6   $��5q�6!   .+�55      �� $ 
Horizontal=�6   .+�56      �� -   5        $��ShowBioPage��56      $%��Принять материал��6-   
����������#696969$��14(�6p   $��4q�57       58      ��%_   '��       �� 59      " ��6    .�5:      �� 	 �@��CornerRadius$
 10��6=   5;      5<      5=      �� 5?      $��Анализаторы��6   
����������#696969$��14(�6W   $��4q�5@      $��10,0,0,0q�6!    5A      ��%_   '��       �� 5B      " ��6    .�5C      �� 	 �@��CornerRadius$
 10��6=   5D      5E      5F      5G      �� 5H      $��Right=�6   .+�5I      �� $��
Назад��6   
����������#696969$��14(�6Q   $��4q�5J      $��10,0,0,0q�6!    5K      ��%_   '��       �� 5L      " ��6    .�5M      �� 	 �@��CornerRadius$
 10��6=   5N      5O      5P      5Q      5R       � 5S   
   -   5          �Name$ NavFrame��5S      $��2��6"   $��0,5,0,0q�6/     � NavigationUIVisibility$ Hidden=�6A   5T      5U      