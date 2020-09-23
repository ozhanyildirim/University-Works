clear all
close all
clc

A=5;
t=0:0.001:1;
f1=20;
f2=5;
x=A.*sin(2*pi*f1*t); % Carrier
subplot(3,1,1);
plot(t,x);
title('Carrier');
grid on;
u=square (2*pi*f2+t); % Sinyal Mesaji
subplot (3,1,2);
plot(t,u);
title('Sinyal Mesaji');

v=x.*u;
subplot (3,1,3);
plot(t,v);
title('PSK');
grid on;

% OZHAN NURI YILDIRIM
% B161210109