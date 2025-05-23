# AssetBundleBenchmark

This project is a simple benchmark for evaluating performance differences
caused by various asset bundle build options in Unity.

### Results on Pixel 7a

Build Options       | No Script Modification | Modified Script |
--                  | --                     | --              |
Normal Asset Bundle | 972 ms                 | 1148 ms         |
Without Typetree    | 800 ms                 | Error           |

- The "Without Typetree" option appears to be faster than the normal asset
  bundle, possibly due to skipping typetree validation.
- The "Modified Script" scenario is significantly slower than the
  no-modification case, because it uses the "safe deserialization" code path.
