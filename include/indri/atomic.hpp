/*==========================================================================
 * Copyright (c) 2004 University of Massachusetts.  All Rights Reserved.
 *
 * Use of the Lemur Toolkit for Language Modeling and Information Retrieval
 * is subject to the terms of the software license set forth in the LICENSE
 * file included with this software, and also available at
 * http://www.lemurproject.org/license.html
 *
 *==========================================================================
 */

//
// atomic
//
//

#ifndef INDRI_ATOMIC_HPP
#define INDRI_ATOMIC_HPP

#include <atomic>
#include <memory>

namespace indri {
/*! \brief Atomic actions for thread support */
namespace atomic {

struct value_type {
  std::shared_ptr<std::atomic_long> value;

  value_type() : value_type(0) {
  }

  value_type(long initialValue) : value(std::make_shared<std::atomic_long>()) {
    *value = 0;
  }

  value_type & operator=(long newValue) {
    *value = newValue;
    return *this;
  }

  operator long() const {
    return *value;
  }
};

inline void increment(value_type &variable) {
  ++(*variable.value);
}

inline void decrement(value_type &variable) {
  --(*variable.value);
}
}
}

#endif // INDRI_ATOMIC_HPP

