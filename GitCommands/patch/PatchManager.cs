                    patch.FileNameA = input.Substring(input.LastIndexOf(" a/") + 3, input.LastIndexOf(" b/") - (input.LastIndexOf(" a/") + 3));
                    patch.FileNameB = input.Substring(input.LastIndexOf(" b/") + 3);
                        if (gitPatch && patch.FileNameB != (input.Substring(6).Trim()))
                        patch.FileNameB = (input.Substring(6).Trim());