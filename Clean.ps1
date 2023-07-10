#!/usr/bin/env pwsh
# remove-item -rec tests/MochaTests/node_modules -erroraction silentlycontinue
# remove-item -rec tests/MochaTests/build -erroraction silentlycontinue
# remove-item -rec .paket -erroraction silentlycontinue
# remove-item -rec paket-files -erroraction silentlycontinue
# remove-item -rec dist -erroraction silentlycontinue
# remove-item -rec dist-sutil -erroraction silentlycontinue
#
# remove-item -rec client/build -erroraction silentlycontinue
# remove-item -rec client/dist -erroraction silentlycontinue
# remove-item -rec client/node_modules -erroraction silentlycontinue
#
# remove-item -rec node_modules -erroraction silentlycontinue
# remove-item -rec src/WldMr.Web.Client.Sutil/build -erroraction silentlycontinue


gci -recurse . -directory | where name -match "^(fableBuild)$" | select fullname | foreach { remove-item -rec -force $_.FullName -erroraction silentlycontinue}
gci -recurse . -directory | where name -match "^(bin|obj)$" | select fullname | foreach { remove-item -rec -force $_.FullName -erroraction silentlycontinue}
gci -recurse . -directory | where name -match "^(node_modules)$" | select fullname | foreach { remove-item -rec -force $_.FullName -erroraction silentlycontinue}
gci -recurse . -directory | where name -match "^(fable_modules)$" | select fullname | foreach { remove-item -rec -force $_.FullName -erroraction silentlycontinue}
