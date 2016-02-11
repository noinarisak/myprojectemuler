#!/bin/bash

# clear terminal
clear

# install the git-flow
echo "installing base tools"
sudo apt-get -y install git-flow make

# install dotnet Core Clr (DNVM, DNU & DNX)
echo "installing dotnet DNVM, DNU & DNX"
sudo apt-get -y install libunwind8 libssl-dev unzip
sudo apt-key adv --keyserver keyserver.ubuntu.com --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb http://download.mono-project.com/repo/debian wheezy main" | sudo tee /etc/apt/sources.list.d/mono-xamarin.list
sudo apt-get -y update

sudo apt-get -y install mono-complete
mozroots --import --sync

echo "installing "
sudo curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh
dnvm upgrade -u
dnvm install latest -r coreclr -u