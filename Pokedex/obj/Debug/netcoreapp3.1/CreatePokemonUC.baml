   M S B A M L   `   `   `  ����B  >Pokedex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PokedexPokedex  5          Pokedex.CreatePokemonUC   5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Pokedex     5      .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TransitionSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6G   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.8.��5      � .+�5      ��  �� Orientation$ Vertical=�6   $	��Top=�64   $��0,130,519,0q�6L   .+�5      �� $ 
Horizontal=�6!   .+�5      ��  �� TextAlignment$ Center=�6$   $��Center=�6;   $��Image��6X   $��18��6e   $��52��6q   �� 5      -   5         ��Name$ 	TextImage��5   "   $��26��65   $	��200��6A   
���   �$y�Visible=�6`   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $ Center=�6$   $��Center=�6;   $
��Name��6X   $��18��6d   $��52��6p   �� 5      -   5        $ TextName��5   "   $��26��64   $	��200��6@   
���   �$y�Visible=�6_   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $ Center=�6$   $��Center=�6;   $
��Type��6X   $��18��6d   $��52��6p   �� 5      -   5        $ TextType��5   "   $��26��64   $	��200��6@   
���   �$y�Visible=�6_   5       �� 5#      $ 
Horizontal=�6!   $	��293��6:   .+�5$      �� $ Center=�6$   $��Description��6;   $��18��6N   $��68��6Z   �� 5%      -   5        $ TextDescription��5%   "   $��26��6;   $	��200��6G   
���   �$y�Visible=�6f   5&      �� 5)      $ 
Horizontal=�6!   .+�5*      �� $ Center=�6$   $��Center=�6;   $��Height��6X   $��18��6f   $��52��6r   �� 5+      -   5        $ 
TextHeight��5+   "   $��26��66   $	��200��6B   
���   �$y�Visible=�6a   5,      �� 5/      $ 
Horizontal=�6!   .+�50      �� $ Center=�6$   $��Center=�6;   $��Weight��6X   $��18��6f   $��52��6r   �� 51      -   5        $ 
TextWeight��51   "   $��26��66   $	��200��6B   
���   �$y�Visible=�6a   52      �� 55      $ 
Horizontal=�6!   .+�56      �� $ Center=�6$   $��Center=�6;   $	��Cry��6X   $��18��6c   $��52��6o   �� 57      -   5        $ TextCry��57   "   $��26��63   $	��200��6?   
���   �$y�Visible=�6^   58      �� 5;      $ 
Horizontal=�6!   .+�5<      �� $ Center=�6$   $��Center=�6;   $��Sound��6X   $��18��6e   $��52��6q   �� 5=      -	   5        $ 	TextSound��5=   "   $��26��65   $	��200��6A   
���   �$y�Visible=�6`   5>      5?      �� 5B      $ Vertical=�6   $	��Top=�64   $��350,130,169,0q�6L   .+�5E      �� $ 
Horizontal=�6!   .+�5F      �� $ Center=�6$   $��Center=�6;   $��HP��6X   $��18��6b   $��52��6n   �� 5G      -
   5        $ TextHP��5G   "   $��26��62   $	��200��6>   
���   �$y�Visible=�6]   5H      �� 5K      $ 
Horizontal=�6!   .+�5L      �� $ Center=�6$   $��Center=�6;   $��Attack��6X   $��18��6f   $��52��6r   �� 5M      -   5        $ 
TextAttack��5M   "   $��26��66   $	��200��6B   
���   �$y�Visible=�6a   5N      �� 5Q      $ 
Horizontal=�6!   .+�5R      �� $ Center=�6$   $��Center=�6;   $��Defense��6X   $��18��6g   $��52��6s   �� 5S      -   5        $ TextDefense��5S   "   $��26��67   $	��200��6C   
���   �$y�Visible=�6b   5T      �� 5W      $ 
Horizontal=�6!   .+�5X      �� $ Center=�6$   $��Center=�6;   $��	Sp.Attack��6X   $��18��6i   $��52��6u   �� 5Y      -   5        $ TextSpAttack��5Y   "   $��26��68   $	��200��6D   
���   �$y�Visible=�6c   5Z      �� 5]      $ 
Horizontal=�6!   .+�5^      �� $ Center=�6$   $��Center=�6;   $��
Sp.Defense��6X   $��18��6j   $��52��6v   �� 5_      -   5        $ TextSpDefense��5_   "   $��26��69   $	��200��6E   
���   �$y�Visible=�6d   5`      �� 5c      $ 
Horizontal=�6!   .+�5d      �� $ Center=�6$   $��Center=�6;   $��Speed��6X   $��18��6e   $��52��6q   �� 5e      -   5        $ 	TextSpeed��5e   "   $��26��65   $	��200��6A   
���   �$y�Visible=�6`   5f      5h      �� 5k      -   5         ��Name$ 
Pokecreate��5k      $��Pokemon Created!��60   $��400,357,281,46q�6H   $y�Hidden=�6`   6v   �� 5n      -   5        $��Create��5n      ���	#F2222222
���""��$
��Left=�6X   $	��Top=�6s   $��262,348,0,0q�6�   5o      5p      5q      5r      